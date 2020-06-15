using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class Programs
    {
        [DisplayName("Program Id")]
        public int Id { get; set; }
        [DisplayName("Program Name")]
        public string Name { get; set; }
        [DisplayName("Total Credit Hour")]
        public float CreditHour { get; set; }
        [DisplayName("Duration")]
        public string Durations { get; set; }
        public Departments Department { get; set; }
    }
}
