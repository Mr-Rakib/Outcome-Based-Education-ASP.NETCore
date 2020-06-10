using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System;
using OBETools.Models;
using OBETools.Utility.Connection;

namespace OBETools.DAL.Repository
{
    public class LoginRepository
    {
        private SqlConnection Connection;
        private SqlCommand Command;
        private SqlDataReader Reader;

        public List<Login> FindAll()
        {
            List<Login> allLogin = new List<Login>();
            using (Connection = Database.GetConnection())
            {
                using (Command= new SqlCommand("sp_getAllLogin", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    using (Reader = Command.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Login login = new Login();
                            login.Username  = Reader["Username"].ToString();
                            login.Password  = Reader["Password"].ToString();
                            login.Role      = Reader["Role"].ToString();
                            allLogin.Add(login);
                        }
                    }
                }
            }
            return allLogin;
        }

        internal bool SaveLogin(Login login)
        {
            using (Connection = Database.GetConnection())
            {
                using (Command = new SqlCommand("sp_getAllLogin", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.Add(new SqlParameter("@Username", login.Username));
                    Command.Parameters.Add(new SqlParameter("@Password", login.Password));
                    Command.Parameters.Add(new SqlParameter("@Role", login.Role));
                    Connection.Open();
                    return (Command.ExecuteNonQuery() > 0) ? true : false;
                }
            }
        }

        public Login FindByUsername(string Username)
        {
            Login login = new Login();
            login = FindAll().Find(login => login.Username == Username);
            return login;
        }

        public Login FindByUsernamePassword(string Username, string Password)
        {
            Login login = new Login();
            login = FindAll().Find(login => login.Username == Username && login.Password == Password);
            return login;
        }

    }
}
