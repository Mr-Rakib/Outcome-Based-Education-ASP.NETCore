using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class CLOToPLOMapping
    {
        public int Id { get; set; }
        public CLO CLO { get; set; }
        public PLO PLO { get; set; }
        public float Points { get; set; }
    }
}
