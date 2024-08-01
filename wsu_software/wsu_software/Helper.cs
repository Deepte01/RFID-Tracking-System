using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsu_software
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
           
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string ReaderCnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
