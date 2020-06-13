using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public Program Program { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
        public string GuardianName { get; set; }
        public string GuardianContact { get; set; }
        public Login Login { get; set; }
    }
}
