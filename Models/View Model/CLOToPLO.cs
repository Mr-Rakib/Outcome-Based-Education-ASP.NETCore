using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models.View_Model
{
    public class CLOToPLO
    {
        public int Id { get; set; }
        public CLO CLO { get; set; }
        public List<MapPLO> MapPLOLists { get; set; }
    }
}
