using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class Mission
    {
        [DisplayName("Mission Id")]
        public int Id { get; set; }
        [DisplayName("Mission Name")]
        public string Name { get; set; }
        [DisplayName("Mission Description")]
        public string Description { get; set; }
    }
}
