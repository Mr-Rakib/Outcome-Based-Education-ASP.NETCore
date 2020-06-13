using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using OBETools.BLL.Interface;
using OBETools.DAL.Repository;
using OBETools.Models;
using OBETools.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace OBETools.BLL.Services
{
    public class LoginService : ILogin
    {
        private static LoginRepository loginRepository = new LoginRepository();

        public List<Login> FindAll(string CurrentUsername)
        {
            List<Login> LoginLists = loginRepository.FindAll();
            return LoginLists;
        }

        public Login FindById(int id, string CurrentUsername)
        {
            return null;
        }

        public Login FindByUsername(string username, string currentUsername)
        {
            Login Login = FindAll(currentUsername).Find(l => l.Username == username);
            return Login;
        }

        internal string IsValidLogin(Login login, string username)
        {
            Login ValidLogin = FindByUsernameAndPassword(login.Username, login.Password, username);
            if (ValidLogin != null)
            {
                if (ValidLogin.Role.ToLower() == Roles.Admin.ToString().ToLower() || ValidLogin.Role.ToLower() == Roles.Superadmin.ToString().ToLower())
                    return null;
                else return Messages.AccessDenied;
            }
            else return Messages.InvalidUser;
        }

        public Login FindByUsernameAndPassword(string username, string password, string currentUsername)
        {
            Login Login = FindAll(currentUsername).Find(l => l.Username == username && l.Password == password);
            return Login;
        }

        public Login GetLogin(Login Login, string currentUsername)
        {
            throw new NotImplementedException();
        }

        public string Update(Login user, string CurrentUsername)
        {
            Login Login = FindByUsername(user.Username, CurrentUsername);
            if (Login != null)
            {
                return (loginRepository.Update(Login)) ? Messages.Updated : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }

        public string Save(Login user, string CurrentUsername)
        {
            throw new NotImplementedException();
        }

        public string Delete(int Id, string CurrentUsername)
        {
            throw new NotImplementedException();
        }
    }
}
