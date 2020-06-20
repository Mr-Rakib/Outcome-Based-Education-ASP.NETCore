using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models.View_Model
{
    public class Mapping
    {
        public List<MissionToPEO> MissionToPEOs { get; set; }
        public List<CLOToPLO> CLOToPLOs { get; set; }
        public List<PLOToPEO> PLOToPEOs { get; set; }
    }
}
