using MySql.Data.MySqlClient;
using OBETools.Models;
using OBETools.Utility;
using OBETools.Utility.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.DAL.Repository
{
    public class CLOToPLOMappingRepository
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<CLOToPLOMapping> FindAll()
        {
            List<CLOToPLOMapping> allCLOToPLOMapping = new List<CLOToPLOMapping>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLCLOToPLOMapping, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CLOToPLOMapping CLOToPLOMapping = new CLOToPLOMapping
                                {
                                    Id = reader.GetInt32("id"),
                                    PLO = new PLO()
                                    {
                                        Id = reader.GetInt32("plo_id")
                                    },
                                    CLO = new CLO()
                                    {
                                        Id = reader.GetInt32("clo_id")
                                    },
                                    Points = reader.GetFloat("points")
                                };
                                allCLOToPLOMapping.Add(CLOToPLOMapping);
                            }
                            
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return allCLOToPLOMapping;
        }

        public bool Update(CLOToPLOMapping CLOToPLOMapping)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.UpdateCLOToPLOMapping, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@Id", CLOToPLOMapping.Id));
                        SetAllParameters(CLOToPLOMapping);

                        connection.Open(); status = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                }
            }
            return (status > 0) ? true : false;
        }

        public bool Save(CLOToPLOMapping CLOToPLOMapping)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.SaveCLOToPLOMapping, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SetAllParameters(CLOToPLOMapping);

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
                    using (command = new MySqlCommand(Procedures.DeleteCLOToPLOMapping, connection))
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

        private void SetAllParameters(CLOToPLOMapping CLOToPLOMapping)
        {
            command.Parameters.Add(new MySqlParameter("@PLOId", CLOToPLOMapping.PLO.Id));
            command.Parameters.Add(new MySqlParameter("@CLOId", CLOToPLOMapping.CLO.Id));
            command.Parameters.Add(new MySqlParameter("@Points", CLOToPLOMapping.Points));
        }

    }
}
