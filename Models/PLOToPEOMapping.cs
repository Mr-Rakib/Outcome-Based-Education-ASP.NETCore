using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class PLOToPEOMapping
    {
        public int Id { get; set; }
        public PLO PLO { get; set; }
        public PEO PEO { get; set; }
        public float Points { get; set; }
    }
}
