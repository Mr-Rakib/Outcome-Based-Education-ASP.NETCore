using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models.View_Model
{
    public class EvaluationWithMapping
    {
        public List<AcademicEvaluationLists> AcademicEvaluationLists { get; set; }
        public List<EvaluationToCLOMapping> EvaluationToCLOMappings { get; set; }
    }
}
