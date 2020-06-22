using MySql.Data.MySqlClient;
using OBETools.Utility.Dependency;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Utility.Connection
{
    public static class Database
    {
        private static MySqlConnection MySQLConnection;
        private static readonly string connectionString = ConfigureAppSettings.Configure.GetSection("Database")["ConnectionString"];

        public static MySqlConnection GetConnection()
        {
            MySQLConnection = null;
            try
            {
                MySQLConnection = new MySqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return MySQLConnection;
        }

    }
}
