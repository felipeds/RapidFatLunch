using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsAutoChat
{
    //TODO: replace hardcoded name
    class Mahape
    {
    

        public List<string> getPlayersOnMyTeam()
        {
            //Esse me'todo vai ser tosco se vira ae



            List<string> teamA = getTeamPlayerNames(1);
            List<string> teamB = getTeamPlayerNames(0);

            if (teamA == null || teamB == null) return null;

            //mimimi que lixo vamos ver qual é o meu time
            foreach(string name in teamA)
            {
                if (name == "kingp1n")
                    return teamA;
            }

            //se n está no timea a com certeza está no B DUH... meu deus mto tempo sem programar... my code is ugly.
            return teamB;

           
        }

        //TODO: deal with no games existing..

        //TODO: encapsular request creation
        private List<string> getTeamPlayerNames(int team) 
        {
            string teamst = "";
            if (team == 1)
                teamst = "teamOne";
            else
                teamst = "teamTwo";
            List<string> rv = new List<string>();
            WebRequest r1 = WebRequest.Create("https://teemojson.p.mashape.com/player/br/"+Properties.Settings.Default.summoner+"/ingame");

            r1.Headers.Add("X-Mashape-Authorization", "qUGWvFAocWiav6n3qk37F00ATPzw2osW");

            WebResponse response;
            try
            {
                response = r1.GetResponse();
            }catch (Exception e)
            {
                //in case of error  return null
                return null;
            }
            

            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream, System.Text.Encoding.UTF8);
            // Read the content.
            string responseFromServer = "";
            while (reader.Peek() >= 0)
            {
                responseFromServer += reader.ReadLine();
            }

            //TODO: Criar a classe certinha apra deserializar... ou deixar com dataset mesm.. sei lá
            try
            {
                JToken token = JObject.Parse(responseFromServer);

                int totalplayers = token["data"]["game"][teamst]["array"].Count();

                for (int i = 0; i < totalplayers; i++)
                {
                    rv.Add((string)token["data"]["game"][teamst]["array"][i]["summonerInternalName"]);
                }
             

            }
            catch (Exception e)
            {
                string b = e.ToString();
                return null;
            }
            return rv;

        }
        
        public Mahape()
        {
         
        }
    


    }
}
