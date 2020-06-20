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
    public class LoginService 
    {
        private static LoginRepository loginRepository = new LoginRepository();

        public List<Login> FindAll(string CurrentUsername)
        {
            List<Login> LoginLists = loginRepository.FindAll();
            return LoginLists;
        }

        public List<Login> FindAll()
        {
            List<Login> LoginLists = loginRepository.FindAll();
            return LoginLists;
        }

        public Login FindByUsername(string username, string currentUsername)
        {
            Login Login = FindAll(currentUsername).Find(l => l.Username == username);
            return Login;
        }

        public Login FindByUsername(string username)
        {
            Login Login = FindAll().Find(l => l.Username == username);
            return Login;
        }

        internal string IsValidLogin(Login login)
        {
            Login ValidLogin = FindByUsernameAndPassword(login.Username, login.Password);
            if (ValidLogin != null)
            {
                if (ValidLogin.Role.ToLower() == Roles.Admin.ToString().ToLower() || ValidLogin.Role.ToLower() == Roles.Superadmin.ToString().ToLower())
                    return null;
                else return Messages.AccessDenied;
            }
            else return Messages.InvalidUser;
        }

        internal void UpdateLastLoginDate(Login login)
        {
            login.LastLoginDate = DateTime.Now;
            Update(login);
        }

        public Login FindByUsernameAndPassword(string username, string password)
        {
            Login Login = FindAll().Find(l => l.Username == username && l.Password == password);
            return Login;
        }

        
        public string Update(Login user)
        {
            Login Login = FindByUsername(user.Username);
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
