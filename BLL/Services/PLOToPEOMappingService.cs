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
    public class PLOToPEOMappingService
    {
        private static PLOToPEOMappingRepository PLOToPEOMappingRepository = new PLOToPEOMappingRepository();
        private static PLOService PLOService = new PLOService();
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
            try
            {
                PLOToPEOMappingLists.ForEach(PLOToPEOMapping => PLOToPEOMapping.PLO = PLOService.FindById(PLOToPEOMapping.PLO.Id, CurrentUsername));
                PLOToPEOMappingLists.ForEach(PLOToPEOMapping => PLOToPEOMapping.PEO = PEOService.FindById(PLOToPEOMapping.PEO.Id, CurrentUsername));
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return PLOToPEOMappingLists;
        }

        public List<PLOToPEO> FindAllPLOToPEO(string CurrentUsername)
        {
            List<PLOToPEO> PLOToPEOs = new List<PLOToPEO>();
            List<PLOToPEOMapping> PLOToPEOMappings = FindAll(CurrentUsername);
            try
            {
                foreach (var items in PLOToPEOMappings)
                {
                    var value = FindByPLOId(items.PLO.Id, CurrentUsername);
                    if (PLOToPEOs != null)
                    {

                        if (PLOToPEOs.Find(v => v.PLO.Id == value.PLO.Id) == null)
                        {
                            PLOToPEOs.Add(value);
                        }
                    }
                    else
                    {
                        PLOToPEOs.Add(value);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return PLOToPEOs;
        }

        internal string SaveMapping(PLOToPEO PLOToPEO, string name)
        {
            try
            {
                PLOToPEO.PLO = PLOService.FindById(PLOToPEO.PLO.Id, name);

                if (PLOToPEO.MapPEOLists.Count > 0)
                {
                    foreach (var item in PLOToPEO.MapPEOLists)
                    {
                        PLOToPEOMapping PLOToPEOMapping = new PLOToPEOMapping()
                        {
                            PLO = PLOToPEO.PLO,
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
            catch (Exception ex)
            {
                Logger.Log(ex);
                return ex.Message;
            }
        }

        internal string UpdateMapping(PLOToPEO PLOToPEO, string name)
        {
            try
            {
                if (PLOToPEO.MapPEOLists.Count > 0)
                {
                    PLOToPEO.PLO = PLOService.FindById(PLOToPEO.PLO.Id, name);
                    if (PLOToPEO != null)
                    {
                        foreach (var item in PLOToPEO.MapPEOLists)
                        {
                            PLOToPEOMapping PLOToPEOMapping = new PLOToPEOMapping()
                            {
                                PLO = PLOToPEO.PLO,
                                PEO = PEOService.FindById(item.PEO.Id, name),
                                Points = item.Points
                            };
                            if (!IsExistMapping(PLOToPEOMapping, name))
                            {
                                Save(PLOToPEOMapping, name);
                            }
                            else
                            {
                                var deleteorUpdate = FindAll(name).Find(mp => mp.PLO.Id == PLOToPEOMapping.PLO.Id && mp.PEO.Id == PLOToPEOMapping.PEO.Id);
                                PLOToPEOMapping.Id = deleteorUpdate.Id;
                                Update(PLOToPEOMapping, name);
                            }
                        }
                        return null;
                    }
                    else return Messages.PLONotFound;
                }
                else return Messages.InvalidField;
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                return ex.Message;
            }
        }

        private bool IsExistMapping(PLOToPEOMapping PLOToPEOMapping, string name)
        {
            try
            {
                var ExistmapPEOs = FindByPLOId(PLOToPEOMapping.PLO.Id, name).MapPEOLists.FindAll(st => st.PEO.Id == PLOToPEOMapping.PEO.Id);
                return (ExistmapPEOs.Count > 0) ? true : false;
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                return false;
            }
        }

        public PLOToPEO FindByPLOId(int id, string CurrentUsername)
        {
            PLOToPEO FoundedPLOToPEO = FindPLOToPEOByPLOId(id, CurrentUsername);
            return FoundedPLOToPEO;
        }

        private PLOToPEO FindPLOToPEOByPLOId(int PLOId, string currentUsername)
        {
            List<PLOToPEOMapping> PLOToPEOMappings = FindAll(currentUsername).FindAll(PLOToPEOMapping => PLOToPEOMapping.PLO.Id == PLOId);
            PLOToPEO PLOToPEO = new PLOToPEO();
            PLOToPEO.PLO = (PLOToPEOMappings.Count > 0) ? PLOToPEOMappings[0].PLO : null;
            PLOToPEO.MapPEOLists = new List<MapPEO>();

            foreach (var items in PLOToPEOMappings)
            {
                MapPEO mapPEO = new MapPEO()
                {
                    PEO = items.PEO,
                    Points = items.Points
                };
                PLOToPEO.MapPEOLists.Add(mapPEO);
            }
            return PLOToPEO;
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
                else return Messages.PLONotFound;
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
                else return Messages.PLONotFound;
            }
            else return Messages.NotFound;
        }

        private string IsValidPLOToPEOMapping(PLOToPEOMapping PLOToPEOMapping, string currentUsername)
        {
            if (PLOService.FindById(PLOToPEOMapping.PLO.Id, currentUsername) != null)
            {
                if (PEOService.FindById(PLOToPEOMapping.PEO.Id, currentUsername) != null)
                {
                    return null;
                }
                else return Messages.PEONotFound;
            }
            else return Messages.PLONotFound;
        }

        public PLOToPEOMapping FindById(int id, string CurrentUsername)
        {
            PLOToPEOMapping PLOToPEOMapping = FindAll(CurrentUsername).Find(mtp => mtp.Id == id);
            return PLOToPEOMapping;
        }
    }
}
