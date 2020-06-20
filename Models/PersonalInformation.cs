using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class PersonalInformation
    {
        [DisplayName("User Id")]
        public int Id { get; set; }
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [DisplayName("Father's Name")]
        public string FathersName { get; set; }
        [DisplayName("Mother's Name")]
        public string MothersName { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Gender")]
        public string Gender { get; set; }
        [DisplayName("Contact")]
        public string Contact { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Present Address")]
        public string PresentAddress { get; set; }
        [DisplayName("Permanent Address")]
        public string PermanentAddress { get; set; }
        [DisplayName("Image")]
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
