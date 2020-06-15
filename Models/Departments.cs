using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class Departments
    {
        [DisplayName("Department Id")]
        public int Id { get; set; }
        [DisplayName("Department Name")]
        public string Name { get; set; }
        [DisplayName("Department Details")]
        public string Description { get; set; }
    }
}
