using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Utility.Connection
{
    public static class Views
    {
        private static readonly string Select = "SELECT * FROM ";

        public static string ALLPEO             = String.Concat(Select, "vw_AllPEO");
        public static string ALLPLO             = String.Concat(Select, "vw_AllPLO");
        public static string AllLogin           = String.Concat(Select, "vw_AllLogin");
        public static string ALLMission         = String.Concat(Select, "vw_AllMission");
        public static string ALLPrograms        = String.Concat(Select, "vw_AllPrograms");
        public static string ALLDepartments     = String.Concat(Select, "vw_AllDepartments");
        public static string ALLExamInformation = String.Concat(Select, "vw_ExamInformation");
        public static string ALLAcademicGrading = String.Concat(Select, "vw_AcademicGrading");

        public static string ALLMissionToPEOMapping =  String.Concat(Select, "vw_AllMissionToPEOMapping");

        public static string ALLPLOToPEOMapping { get; internal set; }
    }
}
