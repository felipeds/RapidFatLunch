using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsAutoChat
{
    class Logger
    {
        private static string path = "log.txt";
        private static string jpath = "JSONlog.txt";

        public static void LogMessage(string message)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                string m = DateTime.Now.ToString() + ": ";
                m += message;
                sw.WriteLine(m);
            }	
        }

        public static void LogJSON(string message)
        {
            using (StreamWriter sw = File.AppendText(jpath))
            {
                string m = DateTime.Now.ToString() + ": ";
                m += message;
                sw.WriteLine(m);
            }
        }
    }
}
