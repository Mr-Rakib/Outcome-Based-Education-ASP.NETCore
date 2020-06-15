using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class PLO
    {
        [DisplayName("PLO Id")]
        public int Id { get; set; }
        public Programs Program { get; set; }
        [DisplayName("PLO Name")]
        public string Name { get; set; }
        [DisplayName("PLO Description")]
        public string Description { get; set; }
    }
}
