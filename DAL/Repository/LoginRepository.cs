using System.Collections.Generic;
using System.Data;
using System;
using OBETools.Models;
using OBETools.Utility.Connection;
using MySql.Data.MySqlClient;
using OBETools.DAL.Interface;
using Microsoft.Extensions.Logging;
using OBETools.Utility;

namespace OBETools.DAL.Repository
{
    public class LoginRepository : ICRUDRepository<Login>
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Login> FindAll()
        {
            List<Login> allLogin = new List<Login>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.AllLogin, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();

                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Login login = new Login()
                                {
                                    Username = reader.GetString("Username"),
                                    Password = reader.GetString("Password"),
                                    Role = reader.GetString("Role"),
                                    IsActive = reader.GetInt32("isActive"),
                                    LastLoginDate = reader.GetDateTime("lastLoginDate")
                                };
                                allLogin.Add(login);
                            }
                            
                            
                        }
                    }
                }
            }catch(Exception ex)
            {
                Logger.Log(ex);
            }
            return allLogin;
        }

        public bool Save(Login Items)
        {
            throw new NotImplementedException();
        }

        public bool Update(Login Items)
        {
            return true;
        }
    }
}
