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
    public class StaffRepository
    {

        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

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
    }
}
