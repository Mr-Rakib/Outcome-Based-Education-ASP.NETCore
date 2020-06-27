using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        [DisplayName("Assessment Name")]
        public string Name{ get; set; }
        [DisplayName("Assessment Type")]
        public string Type{ get; set; }
        public EntryInformation EntryInformation{ get; set; }
    }
}
