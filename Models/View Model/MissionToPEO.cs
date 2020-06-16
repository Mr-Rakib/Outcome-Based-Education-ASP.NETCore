using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models.View_Model
{
    public class MissionToPEO
    {
        public int Id { get; set; }
        public Mission Mission { get; set; }
        public List<MapPEO> MapPEOLists { get; set; } 
    }
}
