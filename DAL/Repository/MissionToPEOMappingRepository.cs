using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using OBETools.DAL.Interface;
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
    public class MissionToPEOMappingRepository : ICRUDRepository<MissionToPEOMapping>
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<MissionToPEOMapping> FindAll()
        {
            List<MissionToPEOMapping> allMissionToPEOMapping = new List<MissionToPEOMapping>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLMissionToPEOMapping, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MissionToPEOMapping MissionToPEOMapping = new MissionToPEOMapping
                                {
                                    Id = reader.GetInt32("id"),
                                    Mission = new Mission()
                                    {
                                        Id = reader.GetInt32("mission_id")
                                    },
                                    PEO = new PEO()
                                    {
                                        Id = reader.GetInt32("peo_id")
                                    },
                                    Points = reader.GetFloat("points")
                                };
                                allMissionToPEOMapping.Add(MissionToPEOMapping);
                            }
                            
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return allMissionToPEOMapping;
        }
        public bool Update(MissionToPEOMapping MissionToPEOMapping)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.UpdateMissionToPEOMapping, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@Id", MissionToPEOMapping.Id));
                        SetAllParameters(MissionToPEOMapping);

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
        public bool Save(MissionToPEOMapping MissionToPEOMapping)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.SaveMissionToPEOMapping, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SetAllParameters(MissionToPEOMapping);

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
                    using (command = new MySqlCommand(Procedures.DeleteMissionToPEOMapping, connection))
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
        private void SetAllParameters(MissionToPEOMapping MissionToPEOMapping)
        {
            command.Parameters.Add(new MySqlParameter("@MissionId", MissionToPEOMapping.Mission.Id));
            command.Parameters.Add(new MySqlParameter("@PEOId", MissionToPEOMapping.PEO.Id));
            command.Parameters.Add(new MySqlParameter("@Points", MissionToPEOMapping.Points));
        }
    }
}
