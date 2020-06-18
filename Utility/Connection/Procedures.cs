using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.Utility.Connection
{
    public static class Procedures
    {
        /// -----------------------------SP UPDATE---------------------------------
        public static string UpdatePEO          = "sp_updatePEO";
        public static string UpdatePLO          = "sp_updatePLO";
        public static string UpdateLogin        = "sp_updateLogin";
        public static string UpdateMission      = "sp_updateMission";
        public static string UpdatePrograms     = "sp_updatePrograms";
        public static string UpdateDepartments  = "sp_updateDepartments";
        
        /// -----------------------------SP SAVE---------------------------------
        public static string SavePEO            = "sp_savePEO";
        public static string SavePLO            = "sp_savePLO";
        public static string SaveMission        = "sp_saveMission";
        public static string SavePrograms       = "sp_savePrograms";
        public static string SaveDepartments    = "sp_saveDepartments";
        
        /// -----------------------------SP DELETE---------------------------------
        public static string DeletePEO          = "sp_deletePEO";
        public static string DeletePLO          = "sp_deletePLO";
        public static string DeleteMission      = "sp_deleteMission";
        public static string DeletePrograms     = "sp_deletePrograms";
        public static string DeleteDepartments  = "sp_deleteDepartments";

        public static string SaveMissionToPEOMapping   = "sp_saveMissionToPEOMapping";
        public static string UpdateMissionToPEOMapping = "sp_updateMissionToPEOMapping";
        public static string DeleteMissionToPEOMapping = "sp_deleteMissionToPEOMapping";

        public static string UpdatePLOToPEOMapping = "sp_updatePLOToPEOMapping";
        public static string SavePLOToPEOMapping   = "sp_savePLOToPEOMapping";
        public static string DeletePLOToPEOMapping = "sp_deletePLOToPEOMapping";

        /// Large Version of SP DELETE

    }
}
