using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string staff_id { get; set; }
        public Department Department { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
        public Login Login { get; set; }
    }
}
