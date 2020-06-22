using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class AcademicEvaluation
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        public int SemesterId { get; set; }
        public Assessment Assessment { get; set; }
        public float Marks { get; set; }
        public EntryInformation EntryInformation { get; set; }
    }
}
