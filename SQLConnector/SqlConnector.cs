using System.IO;

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
                server = configLines[0];
                userid = configLines[1];
                password = configLines[2];
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