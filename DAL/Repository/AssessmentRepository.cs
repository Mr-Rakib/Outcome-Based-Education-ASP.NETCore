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
    public class AssessmentRepository : ICRUDRepository<Assessment>
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<Assessment> FindAll()
        {
            List<Assessment> AllAssessment= new List<Assessment>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLAssessment, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();

                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Assessment Assessment = new Assessment
                                {
                                    Id = reader.GetInt32("id"),
                                    Name = reader.GetString("name"),
                                    Type = reader.GetString("type"),
                                    EntryInformation = new EntryInformation()
                                    {
                                        EntryById = reader.GetInt32("EntryBy_id"),
                                        EntryDate = reader.GetDateTime("EntryDate")
                                    }
                                };
                                AllAssessment.Add(Assessment);
                            }
                            
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return AllAssessment;
        }

        public bool Update(Assessment Assessment)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.UpdateAssessment, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@Id", Assessment.Id));
                        SetAllParameters(Assessment);
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

        private void SetAllParameters(Assessment Assessment)
        {
            command.Parameters.Add(new MySqlParameter("@Name", Assessment.Name));
            command.Parameters.Add(new MySqlParameter("@Type", Assessment.Type));
            command.Parameters.Add(new MySqlParameter("@EntryById", Assessment.EntryInformation.EntryById));
            command.Parameters.Add(new MySqlParameter("@EntryDate", Assessment.EntryInformation.EntryDate));
        }

        public bool Save(Assessment Assessment)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.SaveAssessment, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SetAllParameters(Assessment);
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
                    using (command = new MySqlCommand(Procedures.DeleteAssessment, connection))
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
