using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class Login
    {
        [DisplayName("Username")]
        public string Username { get; set; }
        [DisplayName("Password")]
        public string Password { get; set; }
        [DisplayName("Role")]
        public string Role { get; set; }
        [DisplayName("IsActive")]
        public int IsActive { get; set; }
        [DisplayName("Last Login Date")]
        public DateTime LastLoginDate { get; set; }
    }
}
