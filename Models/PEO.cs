using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class PEO
    {
        [DisplayName("PEO Id")]
        public int Id { get; set; }
        public Programs Program { get; set; }
        [DisplayName("PEO Name")]
        public string Name { get; set; }
        [DisplayName("PEO Description")]
        public string Description { get; set; }
    }
}
