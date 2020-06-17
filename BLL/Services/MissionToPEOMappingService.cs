using MoreLinq;
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

        public List<MissionToPEO> FindAllMissionToPEO(string CurrentUsername)
        {
            List<MissionToPEOMapping> MissionToPEOMappings = FindAll(CurrentUsername);
            List<MissionToPEO> MissionToPEOs = new List<MissionToPEO>();

            foreach (var items in MissionToPEOMappings)
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
                foreach(var item in missionToPEO.MapPEOLists)
                {
                    MissionToPEOMapping missionToPEOMapping = new MissionToPEOMapping()
                    {
                        Mission = MissionService.FindById(missionToPEO.Mission.Id, name),
                        PEO = PEOService.FindById(item.PEO.Id, name),
                        Points = item.Points
                    };
                    if (!IsExistMapping(missionToPEOMapping, name))
                    {
                        Save(missionToPEOMapping, name);
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
                    MissionToPEOMapping missionToPEOMapping = new MissionToPEOMapping()
                    {
                        Mission = MissionService.FindById(missionToPEO.Mission.Id, name),
                        PEO = PEOService.FindById(item.PEO.Id, name),
                        Points = item.Points
                    };
                    if (! IsExistMapping(missionToPEOMapping, name))
                    {
                        Save(missionToPEOMapping, name);
                    }
                    else
                    {
                        var deleteorUpdate = FindAll(name).Find(mp => mp.Mission.Id == missionToPEOMapping.Mission.Id && mp.PEO.Id == missionToPEOMapping.PEO.Id);
                        missionToPEOMapping.Id = deleteorUpdate.Id;
                        Update(missionToPEOMapping, name);
                    }
                }
                return null;
            }
            else return Messages.InvalidField;
        }

        private bool IsExistMapping(MissionToPEOMapping missionToPEOMapping, string name)
        {
            var ExistmapPEOs = FindByMissionId(missionToPEOMapping.Mission.Id, name).MapPEOLists.FindAll(st => st.PEO.Id == missionToPEOMapping.PEO.Id);
            return (ExistmapPEOs.Count > 0) ? true : false;
        }

        public MissionToPEO FindByMissionId(int id, string CurrentUsername)
        {
            MissionToPEO FoundedMissionToPEO = FindMissionToPEOByMissionId(id, CurrentUsername); 
            return FoundedMissionToPEO ;
        }

        private MissionToPEO FindMissionToPEOByMissionId(int missionId, string currentUsername)
        {
            List<MissionToPEOMapping> missionToPEOMappings = FindAll(currentUsername).FindAll(MissionToPEOMapping => MissionToPEOMapping.Mission.Id == missionId);
            MissionToPEO missionToPEO = new MissionToPEO();
            missionToPEO.Mission = (missionToPEOMappings.Count > 0) ? missionToPEOMappings[0].Mission : null ;
            missionToPEO.MapPEOLists = new List<MapPEO>();
            
            foreach (var items in missionToPEOMappings)
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

        public MissionToPEOMapping FindById(int id, string CurrentUsername)
        {
            MissionToPEOMapping MissionToPEOMapping = FindAll(CurrentUsername).Find(mtp => mtp.Id == id);
            return MissionToPEOMapping;
        }
    }
}
