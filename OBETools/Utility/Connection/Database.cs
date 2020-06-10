using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Utility.Connection
{
    public static class Database
    {
        private static string Server = "DESKTOP-ABR0IE7";
        private static string DBName = "OBE";
        private static string ConnectionString = $"Data Source={Server};Initial Catalog = {DBName}; Integrated Security = True";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }
    }
}
