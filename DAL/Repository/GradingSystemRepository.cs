using MySql.Data.MySqlClient;
using OBETools.Models;
using OBETools.Utility;
using OBETools.Utility.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.DAL.Repository
{
    public class GradingSystemRepository
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<GradingSystem> FindAll()
        {
            List<GradingSystem> GradingSystemList = new List<GradingSystem>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLGradingSystem, connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.Text;
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                GradingSystem GradingSystem = new GradingSystem
                                {
                                    Id = reader.GetInt32("id"),
                                    SystemName = reader.GetString("SystemName"),
                                    EntryInformation = new EntryInformation()
                                    {
                                        EntryById = reader.GetInt32("EntryBy_id"),
                                        EntryDate = reader.GetDateTime("EntryDate")
                                    }
                                };
                                GradingSystemList.Add(GradingSystem);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return GradingSystemList;
        }

        public bool Update(GradingSystem GradingSystem)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.UpdateGradingSystem, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@Id", GradingSystem.Id));
                        command.Parameters.Add(new MySqlParameter("@SystemName", GradingSystem.SystemName));
                        command.Parameters.Add(new MySqlParameter("@EntryById", GradingSystem.EntryInformation.EntryById));
                        command.Parameters.Add(new MySqlParameter("@EntryDate", GradingSystem.EntryInformation.EntryDate));

                        connection.Open();
                        status = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                }
            }
            return (status > 0) ? true : false;
        }

        public bool Save(GradingSystem GradingSystem)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.SaveGradingSystem, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@SystemName", GradingSystem.SystemName));
                        command.Parameters.Add(new MySqlParameter("@EntryById", GradingSystem.EntryInformation.EntryById));
                        command.Parameters.Add(new MySqlParameter("@EntryDate", GradingSystem.EntryInformation.EntryDate));

                        connection.Open();
                        status = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                }
            }
            return (status > 0) ? true : false;
        }

        public bool Delete(int id)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.DeleteGradingSystem, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@Id", id));

                        connection.Open();
                        status = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                }
            }
            return (status > 0) ? true : false;
        }

    }
}