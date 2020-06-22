using OBETools.BLL.Services;
using OBETools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Utility.Dependency
{
    public static class Authorization
    {

        private static readonly StaffService StaffService = new StaffService();
        private static readonly LoginService LoginService = new LoginService();

        public static Staff GetCurrentUser(string currentUsername)
        {
            Staff staff = new Staff();
            staff = StaffService.FindAll(currentUsername).Find(st => st.StaffId == currentUsername);
            return staff;
        }

        public static string GetCurrentUserRole(string currentUsername)
        {
            string Role = LoginService.FindByUsername(currentUsername, currentUsername).Role;
            return Role;
        }
    }
}
