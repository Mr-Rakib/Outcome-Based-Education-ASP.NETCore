using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class AcademicEvaluation
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        [DisplayName("Semester ID")]
        public int SemesterId { get; set; }
        public Assessment Assessment { get; set; }
        [DisplayName("Marks")]
        public float Marks { get; set; }
        public EntryInformation EntryInformation { get; set; }
    }
}
