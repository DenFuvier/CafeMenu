using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class SqlConnector
    {
        public string server = "localhost";
        public string userid = "root";
        public string password = "vertrigo";
        public string database = "CafeMenu";

        public string GetConnect()
        {

            return $"server={server};userid={userid};password={password};database={database}";

        }
    }
}
