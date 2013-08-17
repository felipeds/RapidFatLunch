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

        public static void LogMessage(string message)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                string m = DateTime.Now.ToString() + ": ";
                m += message;
                sw.WriteLine(m);
            }	
        }
    }
}
