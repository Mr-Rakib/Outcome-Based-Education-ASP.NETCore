using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class CourseRegistration
    {
        [DisplayName("Registration ID")]
        public int Id { get; set; }
        public RegistrationInformation RegistrationInformation { get; set; }
        [DisplayName("Student ID")]
        public int StudentId { get; set; }
        [DisplayName("Register Time")]
        public DateTime RegisterTime { get; set; }
    }
}
