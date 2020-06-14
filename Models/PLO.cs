using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class PLO
    {
        public int Id { get; set; }
        public Programs Program { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
