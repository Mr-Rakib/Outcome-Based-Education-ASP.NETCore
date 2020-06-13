using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Utility.Connection
{
    public static class Views
    {
        private static readonly string Select = "SELECT * FROM ";

        public static string AllLogin           = String.Concat(Select, "vw_AllLogin");
        public static string ALLExamInformation = String.Concat(Select, "vw_ExamInformation");
        public static string ALLAcademicGrading = String.Concat(Select, "vw_AcademicGrading");

        public static string ALLMission { get; internal set; }
    }
}
