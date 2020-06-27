using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Models
{
    public class EvaluationToCLOMapping
    {
        public int Id { get; set; }
        public AcademicEvaluation AcademicEvaluation { get; set; }
        public CLO CLO { get; set; }
        public float Points  { get; set; }
        public EntryInformation EntryInformation{ get; set; }
    }
}
