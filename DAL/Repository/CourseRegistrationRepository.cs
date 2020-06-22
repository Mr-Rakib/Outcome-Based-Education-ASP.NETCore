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
    public class CourseRegistrationRepository
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<CourseRegistration> FindAll()
        {
            List<CourseRegistration> AllCourseRegistration = new List<CourseRegistration>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLCourseRegistration, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CourseRegistration CourseRegistration = new CourseRegistration()
                                {
                                    Id = reader.GetInt32("id"),
                                    StudentId = reader.GetInt32("student_id"),
                                    RegisterTime = reader.GetDateTime("registertime"),
                                    RegistrationInformation = new RegistrationInformation()
                                    {
                                        Id = reader.GetInt32("registrationInformation_id"),
                                        SemesterId = reader.GetInt32("semester_id"),
                                        Course = new Course()
                                        {
                                          Id = reader.GetInt32("course_id"),
                                        },
                                        FacultyId = reader.GetInt32("faculty_id"),
                                        ClassDay = reader.GetString("ClassDay"),
                                        ClassTimeStart = reader.GetTimeSpan("ClassTimeStart"),
                                        ClassTimeEnd = reader.GetTimeSpan("ClassTimeEnd"),
                                        RoomNumber = reader.GetString("roomNumber"),
                                        Limit = reader.GetInt32("seatLimit"),
                                    },
                                };
                                AllCourseRegistration.Add(CourseRegistration);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return AllCourseRegistration;
        }
    }
}
