using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class MissionToPEOMapping
    {
        public int Id { get; set; }
        public Mission Mission { get; set; }
        public PEO PEO { get; set; }
        public float Points { get; set; }
    }
}
