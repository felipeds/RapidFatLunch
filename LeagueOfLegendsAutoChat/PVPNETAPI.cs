using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;

namespace LeagueOfLegendsAutoChat
{
    class PVPNETAPI
    {

        private static string x_flash_version = "11,5,502,110";
        private static string user_agent = "Mozilla/5.0 (Windows; U; en-US) AppleWebKit/533.19.4 (KHTML, like Gecko) AdobeAIR/3.5";

        public async Task<HttpResponseMessage> AttemptLoginAsync(string username, string password, string server)
        {
            HttpClient client = new HttpClient();
            Dictionary<String, String> postData = new Dictionary<string, string>();
            postData.Add("payload", "user=" + username + ",password=" + password);
            HttpContent content = new FormUrlEncodedContent(postData);

            /* Request structure taken from packet dump
             * 
             * Referer:         app:/LolClient.swf/[[DYNAMIC]]/7
             *                  7 appears to change throughout the client, maybe it indicates state?
             * Accept:          text/xml, application/xml, application/xhtml+xml, text/html;q=0.9, text/plain;q=0.8, text/css, image/png, image/jpeg, image/gif;q=0.8, application/x-shockwave-flash, video/mp4;q=0.9, flv-application/octet-stream;q=0.8, video/x-flv;q=0.7, audio/mp4, application/futuresplash, *\/*;q=0.5
             * x-flash-version: 11,5,502,110
             *                  appears to be the version of flash currently installed. maybe we can read this dynamically instead of hardcoding
             * Accept-Encoding: gzip,deflate
             * User-Agent:      Mozilla/5.0 (Windows; U; en-US) AppleWebKit/533.19.4 (KHTML, like Gecko) AdobeAIR/3.5
             *                  Riot servers appear to be okay with accepting any user agent, but we fake it anyway
             * Host:            lq.eu.lol.riotgames.com
             *                  Host we are connecting to, the one listed here is the EUW server login address
             * Connection:      Keep-Alive
             * Cookie:          mp_super_properties={"all": {"$initial_referrer": "","$initial_referring_domain": "","distinct_id": "22406967"},"events": {},"funnels": {}}
             *                  Not sure what the distinct_id refers to or if it's personally identifiable... it doesn't appear to change, so we'll just send it
             * 
             * Request contains one variable named "payload" containing "user={0},password={1}" where {0} is your case-insensitive username and {1} is your case-sensitive password, both sent in clear (over HTTPS)
             * */

            content.Headers.TryAddWithoutValidation("Referer", "app:/LolClient.swf/[[DYNAMIC]]/7");
            content.Headers.TryAddWithoutValidation("Accept", "text/xml, application/xml, application/xhtml+xml, text/html;q=0.9, text/plain;q=0.8, text/css, image/png, image/jpeg, image/gif;q=0.8, application/x-shockwave-flash, video/mp4;q=0.9, flv-application/octet-stream;q=0.8, video/x-flv;q=0.7, audio/mp4, application/futuresplash, */*;q=0.5");
            content.Headers.TryAddWithoutValidation("x-flash-version", x_flash_version); // forge this to avoid detection
            content.Headers.TryAddWithoutValidation("Accept-Encoding", "gzip,deflate");
            content.Headers.TryAddWithoutValidation("UserAgent", user_agent); // forge this to avoid detection
            content.Headers.TryAddWithoutValidation("Host", server);
            content.Headers.TryAddWithoutValidation("Connection", "Keep-Alive");
            content.Headers.TryAddWithoutValidation("Cookie", "mp_super_properties={\"all\": {\"$initial_referrer\": \"\",\"$initial_referring_domain\": \"\",\"distinct_id\": \"22406967\"},\"events\": {},\"funnels\": {}}");

            Task<HttpResponseMessage> response = client.PostAsync(server, content);
            HttpResponseMessage message = await response;
            return message;
        }
    }
}
