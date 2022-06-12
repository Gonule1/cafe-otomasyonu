using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace PB_Cafe
{
    class Database
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PBCafe"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}
