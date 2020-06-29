using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models.View_Model
{
    public class Grading
    {
        public List<GradingSystem> GradingSystems { get; set; }
        public List<AcademicGrading> AcademicGradings { get; set; }
    }
}
