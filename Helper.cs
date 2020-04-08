using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp1
{
    public static class Helper
    {
        public static string GetConnectionString(string con)
        {
            var output = ConfigurationManager.ConnectionStrings[con].ConnectionString;
            return output;
        }
    }
}
