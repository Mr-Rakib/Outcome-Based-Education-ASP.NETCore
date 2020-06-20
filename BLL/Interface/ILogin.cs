using OBETools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.BLL.Interface
{
    interface ILogin
    {
        Login FindByUsername(string username, string currentUsername);
        Login FindByUsernameAndPassword(string username, string password, string currentUsername);
        Login GetLogin(Login Login, string currentUsername);
    }
}
