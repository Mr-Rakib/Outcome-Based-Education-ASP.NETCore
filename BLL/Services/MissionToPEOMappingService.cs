using OBETools.BLL.Interface;
using OBETools.DAL.Repository;
using OBETools.Models;
using OBETools.Models.View_Model;
using OBETools.Utility;
using System;
using System.Collections.Generic;

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
            try
            {
                MissionToPEOMappingLists.ForEach(MissionToPEOMapping => MissionToPEOMapping.Mission = MissionService.FindById(MissionToPEOMapping.Mission.Id, CurrentUsername));
                MissionToPEOMappingLists.ForEach(MissionToPEOMapping => MissionToPEOMapping.PEO = PEOService.FindById(MissionToPEOMapping.PEO.Id, CurrentUsername));
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return MissionToPEOMappingLists;
        }

        public List<MissionToPEO> FindAllMissionToPEO(string CurrentUsername)
        {
            List<MissionToPEO> MissionToPEOs = new List<MissionToPEO>();
            List<MissionToPEOMapping> MissionToPEOMappings =  FindAll(CurrentUsername);
            try
            {
                foreach (var items in MissionToPEOMappings)
                {
                    var value = FindByMissionId(items.Mission.Id, CurrentUsername);
                    if (MissionToPEOs != null)
                    {

                        if (MissionToPEOs.Find(v => v.Mission.Id == value.Mission.Id) == null)
                        {
                            MissionToPEOs.Add(value);
                        }
                    }
                    else
                    {
                        MissionToPEOs.Add(value);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return MissionToPEOs;
        }

        internal string SaveMapping(MissionToPEO missionToPEO, string name)
        {
            try
            {
                missionToPEO.Mission = MissionService.FindById(missionToPEO.Mission.Id, name);

                if (missionToPEO.MapPEOLists.Count > 0)
                {
                    foreach (var item in missionToPEO.MapPEOLists)
                    {
                        MissionToPEOMapping missionToPEOMapping = new MissionToPEOMapping()
                        {
                            Mission = missionToPEO.Mission,
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
            catch (Exception ex)
            {
                Logger.Log(ex);
                return ex.Message;
            }
        }

        internal string UpdateMapping(MissionToPEO missionToPEO, string name)
        {
            try
            {
                if (missionToPEO.MapPEOLists.Count > 0)
                {
                    missionToPEO.Mission = MissionService.FindById(missionToPEO.Mission.Id, name);
                    if (missionToPEO != null)
                    {
                        foreach (var item in missionToPEO.MapPEOLists)
                        {
                            MissionToPEOMapping missionToPEOMapping = new MissionToPEOMapping()
                            {
                                Mission = missionToPEO.Mission,
                                PEO = PEOService.FindById(item.PEO.Id, name),
                                Points = item.Points
                            };
                            if (!IsExistMapping(missionToPEOMapping, name))
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
                    else return Messages.MissionNotFound;
                }
                else return Messages.InvalidField;
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                return ex.Message;
            }
        }

        private bool IsExistMapping(MissionToPEOMapping missionToPEOMapping, string name)
        {
            try
            {
                var ExistmapPEOs = FindByMissionId(missionToPEOMapping.Mission.Id, name).MapPEOLists.FindAll(st => st.PEO.Id == missionToPEOMapping.PEO.Id);
                return (ExistmapPEOs.Count > 0) ? true : false;
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                return false;
            }
        }

        public MissionToPEO FindByMissionId(int id, string CurrentUsername)
        {
            MissionToPEO FoundedMissionToPEO = FindMissionToPEOByMissionId(id, CurrentUsername);
            return FoundedMissionToPEO;
        }

        private MissionToPEO FindMissionToPEOByMissionId(int missionId, string currentUsername)
        {
            List<MissionToPEOMapping> missionToPEOMappings = FindAll(currentUsername);
            MissionToPEO missionToPEO = new MissionToPEO();
            if (missionToPEOMappings != null)
            {
                try
                {
                    missionToPEOMappings = missionToPEOMappings.FindAll(MissionToPEOMapping => MissionToPEOMapping.Mission.Id == missionId);
                    missionToPEO.Mission = (missionToPEOMappings.Count > 0) ? missionToPEOMappings[0].Mission : null;
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
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                }
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
            try
            {
                if (MissionService.FindById(MissionToPEOMapping.Mission.Id, currentUsername) != null)
                {
                    if (PEOService.FindById(MissionToPEOMapping.PEO.Id, currentUsername) != null)
                    {
                        return null;
                    }
                    else return Messages.PEONotFound;
                }
                else return Messages.MissionNotFound;
            }
            catch(Exception ex)
            {
                Logger.Log(ex);
                return Messages.Issue;
            }
        }

        public MissionToPEOMapping FindById(int id, string CurrentUsername)
        {
            MissionToPEOMapping MissionToPEOMapping = FindAll(CurrentUsername).Find(mtp => mtp.Id == id);
            return MissionToPEOMapping;
        }
    }
}
