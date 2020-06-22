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
    public class CourseRepository : ICRUDRepository<Course>
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Course> FindAll()
        {
            List<Course> allCourse = new List<Course>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLCourse, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Course Course = new Course
                                {
                                    Id              = reader.GetInt32("Id"),
                                    Name            = reader.GetString("name"),
                                    Code            = reader.GetString("code"),
                                    Credit          = reader.GetInt32("credit"),
                                    Descriptions    = reader.GetString("descriptions")
                                };
                                allCourse.Add(Course);
                            }
                            
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return allCourse;
        }

        public bool Save(Course Items)
        {
            throw new NotImplementedException();
        }

        public bool Update(Course Items)
        {
            throw new NotImplementedException();
        }
    }
}
