using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Type{ get; set; }
        public EntryInformation EntryInformation{ get; set; }
    }
}
