using OBETools.BLL.Interface;
using OBETools.DAL.Repository;
using OBETools.Models;
using OBETools.Models.View_Model;
using OBETools.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.BLL.Services
{
    public class MissionToPEOMappingService : ICRUD<MissionToPEOMapping>
    {
        private static MissionToPEOMappingRepository MissionToPEOMappingRepository = new MissionToPEOMappingRepository();
        private static MissionService MissionService = new MissionService();
        private static PEOService PEOService = new PEOService();

        public string Delete(int Id, string CurrentUsername)
        {
            MissionToPEOMapping MissionToPEOMapping = FindById(Id, CurrentUsername);
            if (MissionToPEOMapping != null)
            {
                return MissionToPEOMappingRepository.Delete(Id) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }

        public List<MissionToPEOMapping> FindAll(string CurrentUsername)
        {
            List<MissionToPEOMapping> MissionToPEOMappingLists = MissionToPEOMappingRepository.FindAll();
            MissionToPEOMappingLists.ForEach(MissionToPEOMapping => MissionToPEOMapping.Mission = MissionService.FindById(MissionToPEOMapping.Mission.Id, CurrentUsername));
            MissionToPEOMappingLists.ForEach(MissionToPEOMapping => MissionToPEOMapping.PEO = PEOService.FindById(MissionToPEOMapping.PEO.Id, CurrentUsername));
            return MissionToPEOMappingLists;
        }

        internal string SaveMapping(MissionToPEO missionToPEO, string name)
        {
            if (missionToPEO.MapPEOLists.Count > 0)
            {
                foreach(var item in missionToPEO.MapPEOLists)
                {
                    MissionToPEOMapping missionToPEOMapping = new MissionToPEOMapping()
                    {
                        Mission = MissionService.FindById(missionToPEO.Mission.Id, name),
                        PEO = PEOService.FindById(item.PEO.Id, name),
                        Points = item.Points
                    };

                    if(missionToPEOMapping.Points > 0)
                    {
                        Save(missionToPEOMapping, name);
                    }
                }
                return null;
            }
            else return Messages.InvalidField;
            
        }

        public MissionToPEOMapping FindById(int id, string CurrentUsername)
        {
            MissionToPEOMapping FoundedMissionToPEOMapping = FindAll(CurrentUsername).Find(MissionToPEOMapping => MissionToPEOMapping.Id == id);
            return FoundedMissionToPEOMapping;
        }

        public string Save(MissionToPEOMapping MissionToPEOMapping, string CurrentUsername)
        {
            string message = IsValidMissionToPEOMapping(MissionToPEOMapping, CurrentUsername);
            if (FindById(MissionToPEOMapping.Id, CurrentUsername) == null)
            {
                if (String.IsNullOrEmpty(message))
                {
                    return MissionToPEOMappingRepository.Save(MissionToPEOMapping) ? null : Messages.IssueInDatabase;
                }
                else return Messages.MissionNotFound;
            }
            else return Messages.NotFound;
        }

        public string Update(MissionToPEOMapping MissionToPEOMapping, string CurrentUsername)
        {
            string message = IsValidMissionToPEOMapping(MissionToPEOMapping, CurrentUsername);
            if (FindById(MissionToPEOMapping.Id, CurrentUsername) != null)
            {
                if (String.IsNullOrEmpty(message))
                {
                    return MissionToPEOMappingRepository.Update(MissionToPEOMapping) ? null : Messages.IssueInDatabase;
                }
                else return Messages.MissionNotFound;
            }
            else return Messages.NotFound;
        }

        private string IsValidMissionToPEOMapping(MissionToPEOMapping MissionToPEOMapping, string currentUsername)
        {
            if (MissionService.FindById(MissionToPEOMapping.Mission.Id, currentUsername) != null)
            {
                if (MissionService.FindById(MissionToPEOMapping.Mission.Id, currentUsername) != null)
                {
                    return null;
                }
                else return Messages.PEONotFound;
            }
            else return Messages.MissionNotFound;
        }

    }
}
