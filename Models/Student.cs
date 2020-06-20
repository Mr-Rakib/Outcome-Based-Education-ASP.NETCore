using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class Student
    {
        [DisplayName("Student Id")]
        public int Id { get; set; }
        [DisplayName("Username")]
        public string StudentId { get; set; }
        public Programs Programs{ get; set; }
        public PersonalInformation PersonalInformation { get; set; }
        [DisplayName("Guardian Name")]
        public string GuardianName { get; set; }
        [DisplayName("Guardian Contact")]
        public string GuardianContact { get; set; }
        public Login Login { get; set; }
        
    }
}
