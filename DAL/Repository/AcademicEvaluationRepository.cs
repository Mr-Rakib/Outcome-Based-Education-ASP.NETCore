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
    public class AcademicEvaluationRepository
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<AcademicEvaluation> FindAll()
        {
            List<AcademicEvaluation> allAcademicEvaluation = new List<AcademicEvaluation>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLAcademicEvaluation, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AcademicEvaluation AcademicEvaluation = new AcademicEvaluation
                                {
                                    Id = reader.GetInt32("id"),
                                    Course = new Course()
                                    {
                                        Id = reader.GetInt32("course_id")
                                    },
                                    SemesterId = reader.GetInt32("semester_id"),
                                    Assessment =  new Assessment()
                                    {
                                        Id = reader.GetInt32("assessment_id")
                                    },
                                    Marks = reader.GetFloat("marks"),
                                    EntryInformation = new EntryInformation()
                                    {
                                        EntryById = reader.GetInt32("EntryBy_id"),
                                        EntryDate = reader.GetDateTime("EntryDate")
                                    }
                                };
                                allAcademicEvaluation.Add(AcademicEvaluation);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return allAcademicEvaluation;
        }

        public bool Update(AcademicEvaluation AcademicEvaluation)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.UpdateAcademicEvaluation, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@Id", AcademicEvaluation.Id));
                        SetAllParameters(AcademicEvaluation);
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

        private void SetAllParameters(AcademicEvaluation AcademicEvaluation)
        {
            command.Parameters.Add(new MySqlParameter("@CourseId", AcademicEvaluation.Course.Id));
            command.Parameters.Add(new MySqlParameter("@SemesterId", AcademicEvaluation.SemesterId));
            command.Parameters.Add(new MySqlParameter("@AssessmentId", AcademicEvaluation.Assessment.Id));
            command.Parameters.Add(new MySqlParameter("@Marks", AcademicEvaluation.Marks));
            command.Parameters.Add(new MySqlParameter("@EntryById", AcademicEvaluation.EntryInformation.EntryById));
            command.Parameters.Add(new MySqlParameter("@EntryDate", AcademicEvaluation.EntryInformation.EntryDate));
        }

        public bool Save(AcademicEvaluation AcademicEvaluation)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.SaveAcademicEvaluation, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SetAllParameters(AcademicEvaluation);

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
                    using (command = new MySqlCommand(Procedures.DeleteAcademicEvaluation, connection))
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
