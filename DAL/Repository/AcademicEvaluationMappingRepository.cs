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
    public class AcademicEvaluationMappingMappingRepository
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<AcademicEvaluationMapping> FindAll()
        {
            List<AcademicEvaluationMapping> allAcademicEvaluationMapping = new List<AcademicEvaluationMapping>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLAcademicEvaluationMapping, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AcademicEvaluationMapping AcademicEvaluationMapping = new AcademicEvaluationMapping
                                {
                                    
                                    EntryInformation = new EntryInformation()
                                    {
                                        EntryById = reader.GetInt32("EntryBy_id"),
                                        EntryDate = reader.GetDateTime("EntryDate")
                                    }
                                };
                                allAcademicEvaluationMapping.Add(AcademicEvaluationMapping);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return allAcademicEvaluationMapping;
        }

        public bool Update(AcademicEvaluationMapping AcademicEvaluationMapping)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.UpdateAcademicEvaluationMapping, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@Id", AcademicEvaluationMapping.Id));
                        SetAllParameters(AcademicEvaluationMapping);
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

        private void SetAllParameters(AcademicEvaluationMapping AcademicEvaluationMapping)
        {
            command.Parameters.Add(new MySqlParameter("@EntryById", AcademicEvaluationMapping.EntryInformation.EntryById));
            command.Parameters.Add(new MySqlParameter("@EntryDate", AcademicEvaluationMapping.EntryInformation.EntryDate));
        }

        public bool Save(AcademicEvaluationMapping AcademicEvaluationMapping)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.SaveAcademicEvaluationMapping, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SetAllParameters(AcademicEvaluationMapping);

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
                    using (command = new MySqlCommand(Procedures.DeleteAcademicEvaluationMapping, connection))
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
