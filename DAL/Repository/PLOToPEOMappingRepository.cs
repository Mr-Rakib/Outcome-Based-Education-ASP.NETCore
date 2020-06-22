using Microsoft.Extensions.Logging;
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
    public class PLOToPEOMappingRepository
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<PLOToPEOMapping> FindAll()
        {
            List<PLOToPEOMapping> allPLOToPEOMapping = new List<PLOToPEOMapping>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLPLOToPEOMapping, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PLOToPEOMapping PLOToPEOMapping = new PLOToPEOMapping
                                {
                                    Id = reader.GetInt32("id"),
                                    PLO = new PLO()
                                    {
                                        Id = reader.GetInt32("plo_id")
                                    },
                                    PEO = new PEO()
                                    {
                                        Id = reader.GetInt32("peo_id")
                                    },
                                    Points = reader.GetFloat("points")
                                };
                                allPLOToPEOMapping.Add(PLOToPEOMapping);
                            }
                            
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return allPLOToPEOMapping;
        }
        public bool Update(PLOToPEOMapping PLOToPEOMapping)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.UpdatePLOToPEOMapping, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@Id", PLOToPEOMapping.Id));
                        SetAllParameters(PLOToPEOMapping);

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
        public bool Save(PLOToPEOMapping PLOToPEOMapping)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.SavePLOToPEOMapping, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SetAllParameters(PLOToPEOMapping);

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
                    using (command = new MySqlCommand(Procedures.DeletePLOToPEOMapping, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@id", id));

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
        private void SetAllParameters(PLOToPEOMapping PLOToPEOMapping)
        {
            command.Parameters.Add(new MySqlParameter("@PLOId", PLOToPEOMapping.PLO.Id));
            command.Parameters.Add(new MySqlParameter("@PEOId", PLOToPEOMapping.PEO.Id));
            command.Parameters.Add(new MySqlParameter("@Points", PLOToPEOMapping.Points));
        }

    }
}
