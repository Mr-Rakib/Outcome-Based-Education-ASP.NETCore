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
    public class StaffRepository : ICRUDRepository<Staff>
    {

        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Staff> FindAll()
        {
            List<Staff> allStaff = new List<Staff>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLStaff, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Staff Staff = new Staff
                                {
                                    Id = reader.GetInt32("id"),
                                    StaffId = reader.GetString("Staff_id"),
                                    Department = new Departments()
                                    {
                                        Id = reader.GetInt32("department_id")
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
                                allStaff.Add(Staff);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return allStaff;
        }

        public bool Save(Staff Staff)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.SaveStaff, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SetAllParameters(Staff);
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


        public bool Update(Staff Staff)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.UpdateStaff, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@StudentId", Staff.StaffId));
                        SetAllParameters(Staff);
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
        
        public void SetAllParameters(Staff Staff)
        {
            command.Parameters.Add(new MySqlParameter("@StaffId", Staff.StaffId));
            command.Parameters.Add(new MySqlParameter("@DepartmentId", Staff.Department.Id));
            command.Parameters.Add(new MySqlParameter("@FullName", Staff.PersonalInformation.FullName));
            command.Parameters.Add(new MySqlParameter("@FathersName", Staff.PersonalInformation.FathersName));
            command.Parameters.Add(new MySqlParameter("@MothersName", Staff.PersonalInformation.MothersName));
            command.Parameters.Add(new MySqlParameter("@DateOfBirth", Staff.PersonalInformation.DateOfBirth));
            command.Parameters.Add(new MySqlParameter("@Gender", Staff.PersonalInformation.Gender));
            command.Parameters.Add(new MySqlParameter("@Contact", Staff.PersonalInformation.Contact));
            command.Parameters.Add(new MySqlParameter("@Email", Staff.PersonalInformation.Email));
            command.Parameters.Add(new MySqlParameter("@PresentAddress", Staff.PersonalInformation.PresentAddress));
            command.Parameters.Add(new MySqlParameter("@PermanentAddress", Staff.PersonalInformation.PermanentAddress));
            command.Parameters.Add(new MySqlParameter("@Image", Staff.PersonalInformation.Image));
            command.Parameters.Add(new MySqlParameter("@Password", Staff.Login.Password));
            command.Parameters.Add(new MySqlParameter("@Role", Staff.Login.Role));
            command.Parameters.Add(new MySqlParameter("@LastLoginDate", Staff.Login.LastLoginDate));
            command.Parameters.Add(new MySqlParameter("@IsActive", Staff.Login.IsActive));
        }
    }
}
