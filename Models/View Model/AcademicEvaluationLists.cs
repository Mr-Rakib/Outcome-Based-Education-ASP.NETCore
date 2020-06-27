using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models.View_Model
{
    public class AcademicEvaluationLists
    {
        public int SemesterId { get; set; }
        public Course Course { get; set; }
        public List<MapAssessment> Assessments { get; set; }
    }
}
