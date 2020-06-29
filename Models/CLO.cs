using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class CLO
    {
        [DisplayName("CLO ID")]
        public int Id { get; set; }
        public Course Course { get; set; }
        [DisplayName("CLO Name")]
        public string Name { get; set; }
        [DisplayName("CLO Descriptions")]
        public string Descriptions { get; set; }
    }
}
