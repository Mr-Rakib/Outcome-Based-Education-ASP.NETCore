using OBETools.DAL.Repository;
using OBETools.Models;
using OBETools.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OBETools.BLL.Services
{
    public class LoginService
    {
        private static LoginRepository loginRepository = new LoginRepository();
        internal Login GetLogin(Login login)
        {
            Login getlogin = loginRepository.FindByUsernamePassword(login.Username, login.Password);
            return getlogin;
        }

        internal void SaveLogin(Login login)
        {
            loginRepository.SaveLogin(login);
        }

        internal List<Login> GetAllLogin()
        {
            List<Login> logins = loginRepository.FindAll();
            logins.ForEach(u => u.Password = PasswordCrypt.Encrypt(u.Password));
            return logins; 
        }
    }
}
