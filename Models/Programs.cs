using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class Programs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float CreditHour { get; set; }
        public string Durations { get; set; }
        public Departments Department { get; set; }
    }
}
