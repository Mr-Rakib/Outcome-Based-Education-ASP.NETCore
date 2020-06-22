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
    public class PLORepository : ICRUDRepository<PLO>
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<PLO> FindAll()
        {
            List<PLO> allPLO = new List<PLO>();
            try
            {
                using (connection = Database.GetConnection())
                {
                    using (command = new MySqlCommand(Views.ALLPLO, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PLO PLO = new PLO
                                {
                                    Id = reader.GetInt32("id"),
                                    Program = new Programs()
                                    {
                                        Id = reader.GetInt32("program_id")
                                    },
                                    Name = reader.GetString("Name"),
                                    Description = reader.GetString("descriptions")
                                };
                                allPLO.Add(PLO);
                            }
                            
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return allPLO;
        }

        public bool Update(PLO PLO)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.UpdatePLO, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@id", PLO.Id));
                        command.Parameters.Add(new MySqlParameter("@ProgramId", PLO.Program.Id));
                        command.Parameters.Add(new MySqlParameter("@name", PLO.Name));
                        command.Parameters.Add(new MySqlParameter("@Description", PLO.Description));

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

        public bool Save(PLO PLO)
        {
            int status = 0;
            using (connection = Database.GetConnection())
            {
                try
                {
                    using (command = new MySqlCommand(Procedures.SavePLO, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new MySqlParameter("@ProgramId", PLO.Program.Id));
                        command.Parameters.Add(new MySqlParameter("@name", PLO.Name));
                        command.Parameters.Add(new MySqlParameter("@Description", PLO.Description));

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
                    using (command = new MySqlCommand(Procedures.DeletePLO, connection))
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
