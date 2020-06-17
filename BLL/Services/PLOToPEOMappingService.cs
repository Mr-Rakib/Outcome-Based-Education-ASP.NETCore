using OBETools.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.BLL.Services
{
    public class PLOToPEOMappingService
    {
        private static PLOToPEOMappingRepository PLOToPEOMappingRepository = new PLOToPEOMappingRepository();
        private static MissionService MissionService = new MissionService();
        private static PEOService PEOService = new PEOService();

        public string Delete(int Id, string CurrentUsername)
        {
            PLOToPEOMapping PLOToPEOMapping = FindById(Id, CurrentUsername);
            if (PLOToPEOMapping != null)
            {
                return PLOToPEOMappingRepository.Delete(Id) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }

        public List<PLOToPEOMapping> FindAll(string CurrentUsername)
        {
            List<PLOToPEOMapping> PLOToPEOMappingLists = PLOToPEOMappingRepository.FindAll();
            PLOToPEOMappingLists.ForEach(PLOToPEOMapping => PLOToPEOMapping.Mission = MissionService.FindById(PLOToPEOMapping.Mission.Id, CurrentUsername));
            PLOToPEOMappingLists.ForEach(PLOToPEOMapping => PLOToPEOMapping.PEO = PEOService.FindById(PLOToPEOMapping.PEO.Id, CurrentUsername));
            return PLOToPEOMappingLists;
        }

        public List<MissionToPEO> FindAllMissionToPEO(string CurrentUsername)
        {
            List<PLOToPEOMapping> PLOToPEOMappings = FindAll(CurrentUsername);
            List<MissionToPEO> MissionToPEOs = new List<MissionToPEO>();

            foreach (var items in PLOToPEOMappings)
            {
                var value = FindByMissionId(items.Mission.Id, CurrentUsername);
                if (MissionToPEOs.Find(v => v.Mission.Id == value.Mission.Id) == null)
                {
                    MissionToPEOs.Add(value);
                }
            }
            return MissionToPEOs;
        }

        internal string SaveMapping(MissionToPEO missionToPEO, string name)
        {
            if (missionToPEO.MapPEOLists.Count > 0)
            {
                foreach (var item in missionToPEO.MapPEOLists)
                {
                    PLOToPEOMapping PLOToPEOMapping = new PLOToPEOMapping()
                    {
                        Mission = MissionService.FindById(missionToPEO.Mission.Id, name),
                        PEO = PEOService.FindById(item.PEO.Id, name),
                        Points = item.Points
                    };
                    if (!IsExistMapping(PLOToPEOMapping, name))
                    {
                        Save(PLOToPEOMapping, name);
                    }
                }
                return null;
            }
            else return Messages.InvalidField;

        }

        internal string UpdateMapping(MissionToPEO missionToPEO, string name)
        {
            if (missionToPEO.MapPEOLists.Count > 0)
            {
                foreach (var item in missionToPEO.MapPEOLists)
                {
                    PLOToPEOMapping PLOToPEOMapping = new PLOToPEOMapping()
                    {
                        Mission = MissionService.FindById(missionToPEO.Mission.Id, name),
                        PEO = PEOService.FindById(item.PEO.Id, name),
                        Points = item.Points
                    };
                    if (!IsExistMapping(PLOToPEOMapping, name))
                    {
                        Save(PLOToPEOMapping, name);
                    }
                    else
                    {
                        var deleteorUpdate = FindAll(name).Find(mp => mp.Mission.Id == PLOToPEOMapping.Mission.Id && mp.PEO.Id == PLOToPEOMapping.PEO.Id);
                        PLOToPEOMapping.Id = deleteorUpdate.Id;
                        Update(PLOToPEOMapping, name);
                    }
                }
                return null;
            }
            else return Messages.InvalidField;
        }

        private bool IsExistMapping(PLOToPEOMapping PLOToPEOMapping, string name)
        {
            var ExistmapPEOs = FindByMissionId(PLOToPEOMapping.Mission.Id, name).MapPEOLists.FindAll(st => st.PEO.Id == PLOToPEOMapping.PEO.Id);
            return (ExistmapPEOs.Count > 0) ? true : false;
        }

        public MissionToPEO FindByMissionId(int id, string CurrentUsername)
        {
            MissionToPEO FoundedMissionToPEO = FindMissionToPEOByMissionId(id, CurrentUsername);
            return FoundedMissionToPEO;
        }

        private MissionToPEO FindMissionToPEOByMissionId(int missionId, string currentUsername)
        {
            List<PLOToPEOMapping> PLOToPEOMappings = FindAll(currentUsername).FindAll(PLOToPEOMapping => PLOToPEOMapping.Mission.Id == missionId);
            MissionToPEO missionToPEO = new MissionToPEO();
            missionToPEO.Mission = (PLOToPEOMappings.Count > 0) ? PLOToPEOMappings[0].Mission : null;
            missionToPEO.MapPEOLists = new List<MapPEO>();

            foreach (var items in PLOToPEOMappings)
            {
                MapPEO mapPEO = new MapPEO()
                {
                    PEO = items.PEO,
                    Points = items.Points
                };
                missionToPEO.MapPEOLists.Add(mapPEO);
            }
            return missionToPEO;
        }

        public string Save(PLOToPEOMapping PLOToPEOMapping, string CurrentUsername)
        {
            string message = IsValidPLOToPEOMapping(PLOToPEOMapping, CurrentUsername);
            if (FindById(PLOToPEOMapping.Id, CurrentUsername) == null)
            {
                if (String.IsNullOrEmpty(message))
                {
                    return PLOToPEOMappingRepository.Save(PLOToPEOMapping) ? null : Messages.IssueInDatabase;
                }
                else return Messages.MissionNotFound;
            }
            else return Messages.NotFound;
        }

        public string Update(PLOToPEOMapping PLOToPEOMapping, string CurrentUsername)
        {
            string message = IsValidPLOToPEOMapping(PLOToPEOMapping, CurrentUsername);
            if (FindById(PLOToPEOMapping.Id, CurrentUsername) != null)
            {
                if (String.IsNullOrEmpty(message))
                {
                    return PLOToPEOMappingRepository.Update(PLOToPEOMapping) ? null : Messages.IssueInDatabase;
                }
                else return Messages.MissionNotFound;
            }
            else return Messages.NotFound;
        }

        private string IsValidPLOToPEOMapping(PLOToPEOMapping PLOToPEOMapping, string currentUsername)
        {
            if (MissionService.FindById(PLOToPEOMapping.Mission.Id, currentUsername) != null)
            {
                if (MissionService.FindById(PLOToPEOMapping.Mission.Id, currentUsername) != null)
                {
                    return null;
                }
                else return Messages.PEONotFound;
            }
            else return Messages.MissionNotFound;
        }

        public PLOToPEOMapping FindById(int id, string CurrentUsername)
        {
            PLOToPEOMapping PLOToPEOMapping = FindAll(CurrentUsername).Find(mtp => mtp.Id == id);
            return PLOToPEOMapping;
        }
    }
}
