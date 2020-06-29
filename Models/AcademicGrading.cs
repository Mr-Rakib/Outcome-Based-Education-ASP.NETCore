using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class AcademicGrading
    {
        [DisplayName("Grading ID")]
        public int Id { get; set; }
        public GradingSystem GradingSystem { get; set; }
        [DisplayName("Grade Name")]
        public string GradeName { get; set; }
        [DisplayName("Percentage Form")]
        public float PercentageFrom { get; set; }
        [DisplayName("Percentage To")]
        public float PercentageTo { get; set; }
        [DisplayName("GPA")]
        public float Gpa { get; set; }
    }
}
