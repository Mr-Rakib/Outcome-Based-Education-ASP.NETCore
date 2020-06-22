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
    public class StudentRepository : ICRUDRepository<Student>
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

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

        public bool Save(Student Student)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.SaveStudent, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SetAllParameters(Student);
                        connection.Open();
                        status = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    return false;
                }
            }
            return true ;
        }


        public bool Update(Student Student)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.UpdateStudent, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@StudentId", Student.StudentId));
                        SetAllParameters(Student);
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
        
        private void SetAllParameters(Student Student)
        {
            command.Parameters.Add(new MySqlParameter("@StudentId", Student.StudentId));
            command.Parameters.Add(new MySqlParameter("@ProgramId", Student.Programs.Id));
            command.Parameters.Add(new MySqlParameter("@GuardianName", Student.GuardianName));
            command.Parameters.Add(new MySqlParameter("@GuardianContact", Student.GuardianContact));
            command.Parameters.Add(new MySqlParameter("@FullName", Student.PersonalInformation.FullName));
            command.Parameters.Add(new MySqlParameter("@FathersName", Student.PersonalInformation.FathersName));
            command.Parameters.Add(new MySqlParameter("@MothersName", Student.PersonalInformation.MothersName));
            command.Parameters.Add(new MySqlParameter("@DateOfBirth", Student.PersonalInformation.DateOfBirth));
            command.Parameters.Add(new MySqlParameter("@Gender", Student.PersonalInformation.Gender));
            command.Parameters.Add(new MySqlParameter("@Contact", Student.PersonalInformation.Contact));
            command.Parameters.Add(new MySqlParameter("@Email", Student.PersonalInformation.Email));
            command.Parameters.Add(new MySqlParameter("@PresentAddress", Student.PersonalInformation.PresentAddress));
            command.Parameters.Add(new MySqlParameter("@PermanentAddress", Student.PersonalInformation.PermanentAddress));
            command.Parameters.Add(new MySqlParameter("@Image", Student.PersonalInformation.Image));
            command.Parameters.Add(new MySqlParameter("@Password", Student.Login.Password));
            command.Parameters.Add(new MySqlParameter("@Role", Student.Login.Role));
            command.Parameters.Add(new MySqlParameter("@LastLoginDate", Student.Login.LastLoginDate));
            command.Parameters.Add(new MySqlParameter("@IsActive", Student.Login.IsActive));

        }
    }
}
