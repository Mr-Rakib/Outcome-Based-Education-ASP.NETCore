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
    public class CLORepository : ICRUDRepository<CLO>
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<CLO> FindAll()
        {
            List<CLO> allCLO = new List<CLO>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLCLO, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CLO CLO = new CLO
                                {
                                    Id = reader.GetInt32("id"),
                                    Course = new Course()
                                    {
                                        Id = reader.GetInt32("course_id")
                                    },
                                    Name = reader.GetString("Name"),
                                    Descriptions = reader.GetString("descriptions")
                                };
                                allCLO.Add(CLO);
                            }
                            
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return allCLO;
        }

        public bool Update(CLO CLO)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.UpdateCLO, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@Id", CLO.Id));
                        command.Parameters.Add(new MySqlParameter("@CourseId", CLO.Course.Id));
                        command.Parameters.Add(new MySqlParameter("@Name", CLO.Name));
                        command.Parameters.Add(new MySqlParameter("@Descriptions", CLO.Descriptions));

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

        public bool Save(CLO CLO)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.SaveCLO, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@CourseId", CLO.Course.Id));
                        command.Parameters.Add(new MySqlParameter("@Name", CLO.Name));
                        command.Parameters.Add(new MySqlParameter("@Descriptions", CLO.Descriptions));

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
                    using (command = new MySqlCommand(Procedures.DeleteCLO, connection))
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
