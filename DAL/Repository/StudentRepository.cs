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
    public class StudentRepository
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<Student> FindAll()
        {
            List<Student> allStudent = new List<Student>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLStudent, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Student Student = new Student
                                {
                                    Id = reader.GetInt32("id"),
                                    StudentId = reader.GetString("student_id"),
                                    GuardianName = reader.GetString("guardianName"),
                                    GuardianContact = reader.GetString("guardianContact"),
                                    Programs = new Programs()
                                    {
                                        Id = reader.GetInt32("program_id")
                                    },
                                    PersonalInformation = new PersonalInformation()
                                    {
                                        FullName = reader.GetString("fullName"),
                                        FathersName = reader.GetString("fathersName"),
                                        MothersName = reader.GetString("mothersName"),
                                        DateOfBirth = reader.GetDateTime("dateOfBirth"),
                                        Gender = reader.GetString("gender"),
                                        Contact = reader.GetString("contact"),
                                        Email = reader.GetString("email"),
                                        PermanentAddress = reader.GetString("permanentAddress"),
                                        PresentAddress = reader.GetString("presentAddress"),
                                        Image = reader.GetString("image")
                                    },
                                   Login = new Login()
                                   {
                                       Username = reader.GetString("username")
                                   }

                                };
                                allStudent.Add(Student);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return allStudent;
        }

    }
}
