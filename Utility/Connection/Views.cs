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
        public static string ALLCLO             = String.Concat(Select, "vw_AllCLOS");
        public static string AllLogin           = String.Concat(Select, "vw_AllLogin");
        public static string ALLStaff           = String.Concat(Select, "vw_AllStaffs");
        public static string ALLCourse          = String.Concat(Select, "vw_AllCourses");
        public static string ALLStudent         = String.Concat(Select, "vw_AllStudents");
        public static string ALLMission         = String.Concat(Select, "vw_AllMission");
        public static string ALLPrograms        = String.Concat(Select, "vw_AllPrograms");
        public static string ALLDepartments     = String.Concat(Select, "vw_AllDepartments");
        public static string ALLExamInformation = String.Concat(Select, "vw_ExamInformation");
        public static string ALLAcademicGrading = String.Concat(Select, "vw_AcademicGrading");
        public static string ALLPLOToPEOMapping = String.Concat(Select, "vw_AllPLOToPEOMapping");
        public static string ALLCLOToPLOMapping = String.Concat(Select, "vw_AllCLOToPLOMapping");

        public static string ALLMissionToPEOMapping =  String.Concat(Select, "vw_AllMissionToPEOMapping");

        public static string ALLAssessment = String.Concat(Select, "vw_AllAssessment");
        public static string ALLAcademicEvaluation = String.Concat(Select, "vw_allAcademicEvaluation");
        public static string ALLCourseRegistration = String.Concat(Select, "vw_allregistrationinformation");

        public static string ALLEvaluationtToCLOMapping = String.Concat(Select, "vw_allacademicevaluationttoclomapping");

        public static string ALLGradingSystem = String.Concat(Select, "vw_ALLGradingSystem");
    }
}
