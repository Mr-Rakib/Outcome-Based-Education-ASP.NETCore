using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class GradingSystem
    {
        [DisplayName("Grading System")]
        public int Id { get; set; }
        [DisplayName("System Name")]
        public string SystemName { get; set; }
        public EntryInformation EntryInformation { get; set; }
    }
}