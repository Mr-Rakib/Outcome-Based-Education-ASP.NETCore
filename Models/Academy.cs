using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class Academy
    {
        public List<Mission> Missions { get; set; }
        public List<PEO> PEOs { get; set; }
        public List<PLO> PLOs { get; set; }
        public List<CLO> CLOs { get; set; }
    }
}
