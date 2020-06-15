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
    public class ProgramRepository
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<Programs> FindAll()
        {
            List<Programs> allPrograms = new List<Programs>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLPrograms, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Programs Programs = new Programs
                                {
                                    Id = reader.GetInt32("id"),
                                    Department = new Departments()
                                    {
                                        Id = reader.GetInt32("department_id")
                                    },
                                    Name        = reader.GetString("Name"),
                                    CreditHour  = reader.GetFloat("creditHour"),
                                    Durations   = reader.GetString("duration")
                                };
                                allPrograms.Add(Programs);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return allPrograms;
        }

        public bool Update(Programs Programs)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.UpdatePrograms, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@id", Programs.Id));
                        command.Parameters.Add(new MySqlParameter("@Name", Programs.Name));
                        command.Parameters.Add(new MySqlParameter("@CreditHour", Programs.CreditHour));
                        command.Parameters.Add(new MySqlParameter("@Durations", Programs.Durations));
                        command.Parameters.Add(new MySqlParameter("@DepartmentId", Programs.Department.Id));

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

        public bool Save(Programs Programs)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.SavePrograms, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@Name", Programs.Name));
                        command.Parameters.Add(new MySqlParameter("@CreditHour", Programs.CreditHour));
                        command.Parameters.Add(new MySqlParameter("@Durations", Programs.Durations));
                        command.Parameters.Add(new MySqlParameter("@DepartmentId", Programs.Department.Id));

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
                    using (command = new MySqlCommand(Procedures.DeletePrograms, connection))
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
