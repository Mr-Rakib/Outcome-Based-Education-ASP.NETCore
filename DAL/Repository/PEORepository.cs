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
    public class PEORepository : ICRUDRepository<PEO>
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<PEO> FindAll()
        {
            List<PEO> allPEO = new List<PEO>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLPEO, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PEO PEO = new PEO
                                {
                                    Id = reader.GetInt32("id"),
                                    Program = new Programs()
                                    {
                                        Id = reader.GetInt32("program_id")
                                    },
                                    Name = reader.GetString("Name"),
                                    Description = reader.GetString("descriptions")
                                };
                                allPEO.Add(PEO);
                            }
                            
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return allPEO;
        }

        public bool Update(PEO PEO)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.UpdatePEO, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@Id", PEO.Id));
                        command.Parameters.Add(new MySqlParameter("@ProgramId", PEO.Program.Id));
                        command.Parameters.Add(new MySqlParameter("@Name", PEO.Name));
                        command.Parameters.Add(new MySqlParameter("@Description", PEO.Description));

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

        public bool Save(PEO PEO)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.SavePEO, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@programId", PEO.Program.Id));
                        command.Parameters.Add(new MySqlParameter("@name", PEO.Name));
                        command.Parameters.Add(new MySqlParameter("@Description", PEO.Description));

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
                    using (command = new MySqlCommand(Procedures.DeletePEO, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@id", id));

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
