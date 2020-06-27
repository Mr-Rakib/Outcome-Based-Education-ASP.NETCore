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
    public class EvaluationToCLOMappingRepository
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<EvaluationToCLOMapping> FindAll()
        {
            List<EvaluationToCLOMapping> allEvaluationtToCLOMapping = new List<EvaluationToCLOMapping>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLEvaluationtToCLOMapping, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EvaluationToCLOMapping EvaluationtToCLOMapping = new EvaluationToCLOMapping
                                {
                                    Id = reader.GetInt32("id"),
                                    AcademicEvaluation = new AcademicEvaluation()
                                    {
                                        Id = reader.GetInt32("academicevaluation_id")
                                    },
                                    CLO = new CLO()
                                    {
                                        Id = reader.GetInt32("clo_id")
                                    },
                                    Points = reader.GetFloat("points"),
                                    EntryInformation = new EntryInformation()
                                    {
                                        EntryById = reader.GetInt32("EntryBy_id"),
                                        EntryDate = reader.GetDateTime("EntryDate")
                                    }
                                };
                                allEvaluationtToCLOMapping.Add(EvaluationtToCLOMapping);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return allEvaluationtToCLOMapping;
        }

        public bool Update(EvaluationToCLOMapping EvaluationtToCLOMapping)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.UpdateEvaluationtToCLOMapping, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@Id", EvaluationtToCLOMapping.Id));
                        SetAllParameters(EvaluationtToCLOMapping);
                        
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

        public bool Save(EvaluationToCLOMapping EvaluationtToCLOMapping)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.SaveEvaluationtToCLOMapping, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SetAllParameters(EvaluationtToCLOMapping);

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
                    using (command = new MySqlCommand(Procedures.DeleteEvaluationtToCLOMapping, connection))
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
        private void SetAllParameters(EvaluationToCLOMapping EvaluationtToCLOMapping)
        {

            command.Parameters.Add(new MySqlParameter("@CLOId", EvaluationtToCLOMapping.CLO.Id));
            command.Parameters.Add(new MySqlParameter("@Points", EvaluationtToCLOMapping.Points));
            command.Parameters.Add(new MySqlParameter("@EntryDate", EvaluationtToCLOMapping.EntryInformation.EntryDate));
            command.Parameters.Add(new MySqlParameter("@EntryById", EvaluationtToCLOMapping.EntryInformation.EntryById));
            command.Parameters.Add(new MySqlParameter("@AcademicEvaluationId", EvaluationtToCLOMapping.AcademicEvaluation.Id));
        }
    }
}
