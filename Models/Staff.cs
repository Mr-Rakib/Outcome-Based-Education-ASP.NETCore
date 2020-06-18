using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class Staff
    {
        [DisplayName("Staff Id")]
        public int Id { get; set; }
        [DisplayName("Staff Username")]
        public string StaffId { get; set; }
        public Departments Department { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
        public Login Login { get; set; }
    }
}
