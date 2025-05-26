using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class SqlConnector
    {
        public string server;
        public string userid;
        public string password;
        public string database;

        public SqlConnector()
        {
            string[] configLines = File.ReadAllLines("config.txt");

            if (configLines.Length >= 4)
            {
                userid = configLines[0];
                password = configLines[1];
                server = configLines[2];
                database = configLines[3];
            }
            else
            {

                server = "localhost";
                userid = "root";
                password = "vertrigo";
                database = "CafeMenu";
            }
        }
        public string GetConnect()
        {
            return $"server={server};userid={userid};password={password};database={database}";
        }
    }
}
