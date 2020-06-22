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
    public class CLOToPLOMappingService
    {
        private static CLOToPLOMappingRepository CLOToPLOMappingRepository = new CLOToPLOMappingRepository();
        private static CLOService CLOService = new CLOService();
        private static PLOService PLOService = new PLOService();

        public string Delete(int Id, string CurrentUsername)
        {
            CLOToPLOMapping CLOToPLOMapping = FindById(Id, CurrentUsername);
            if (CLOToPLOMapping != null)
            {
                return CLOToPLOMappingRepository.Delete(Id) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }

        public List<CLOToPLOMapping> FindAll(string CurrentUsername)
        {
            List<CLOToPLOMapping> CLOToPLOMappingLists = CLOToPLOMappingRepository.FindAll();
            try
            {
                CLOToPLOMappingLists.ForEach(CLOToPLOMapping => CLOToPLOMapping.CLO = CLOService.FindById(CLOToPLOMapping.CLO.Id, CurrentUsername));
                CLOToPLOMappingLists.ForEach(CLOToPLOMapping => CLOToPLOMapping.PLO = PLOService.FindById(CLOToPLOMapping.PLO.Id, CurrentUsername));
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return CLOToPLOMappingLists;
        }

        public List<CLOToPLO> FindAllCLOToPLO(string CurrentUsername)
        {
            List<CLOToPLO> CLOToPLOs = new List<CLOToPLO>();
            List<CLOToPLOMapping> CLOToPLOMappings = FindAll(CurrentUsername);
            try
            {
                foreach (var items in CLOToPLOMappings)
                {
                    var value = FindByCLOId(items.CLO.Id, CurrentUsername);
                    if (CLOToPLOs != null)
                    {

                        if (CLOToPLOs.Find(v => v.CLO.Id == value.CLO.Id) == null)
                        {
                            CLOToPLOs.Add(value);
                        }
                    }
                    else
                    {
                        CLOToPLOs.Add(value);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
            return CLOToPLOs;
        }

        internal string SaveMapping(CLOToPLO CLOToPLO, string name)
        {
            try
            {
                CLOToPLO.CLO = CLOService.FindById(CLOToPLO.CLO.Id, name);

                if (CLOToPLO.MapPLOLists.Count > 0)
                {
                    foreach (var item in CLOToPLO.MapPLOLists)
                    {
                        CLOToPLOMapping CLOToPLOMapping = new CLOToPLOMapping()
                        {
                            CLO = CLOToPLO.CLO,
                            PLO = PLOService.FindById(item.PLO.Id, name),
                            Points = item.Points
                        };
                        if (!IsExistMapping(CLOToPLOMapping, name))
                        {
                            Save(CLOToPLOMapping, name);
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

        internal string UpdateMapping(CLOToPLO CLOToPLO, string name)
        {
            try
            {
                if (CLOToPLO.MapPLOLists.Count > 0)
                {
                    CLOToPLO.CLO = CLOService.FindById(CLOToPLO.CLO.Id, name);
                    if (CLOToPLO != null)
                    {
                        foreach (var item in CLOToPLO.MapPLOLists)
                        {
                            CLOToPLOMapping CLOToPLOMapping = new CLOToPLOMapping()
                            {
                                CLO = CLOToPLO.CLO,
                                PLO = PLOService.FindById(item.PLO.Id, name),
                                Points = item.Points
                            };
                            if (!IsExistMapping(CLOToPLOMapping, name))
                            {
                                Save(CLOToPLOMapping, name);
                            }
                            else
                            {
                                var deleteorUpdate = FindAll(name).Find(mp => mp.CLO.Id == CLOToPLOMapping.CLO.Id && mp.PLO.Id == CLOToPLOMapping.PLO.Id);
                                CLOToPLOMapping.Id = deleteorUpdate.Id;
                                Update(CLOToPLOMapping, name);
                            }
                        }
                        return null;
                    }
                    else return Messages.CLONotFound;
                }
                else return Messages.InvalidField;
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                return ex.Message;
            }
        }

        private bool IsExistMapping(CLOToPLOMapping CLOToPLOMapping, string name)
        {
            try
            {
                var ExistmapPLOs = FindByCLOId(CLOToPLOMapping.CLO.Id, name).MapPLOLists.FindAll(st => st.PLO.Id == CLOToPLOMapping.PLO.Id);
                return (ExistmapPLOs.Count > 0) ? true : false;
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                return false;
            }
        }

        public CLOToPLO FindByCLOId(int id, string CurrentUsername)
        {
            CLOToPLO FoundedCLOToPLO = FindCLOToPLOByCLOId(id, CurrentUsername);
            return FoundedCLOToPLO;
        }

        private CLOToPLO FindCLOToPLOByCLOId(int CLOId, string currentUsername)
        {
            List<CLOToPLOMapping> CLOToPLOMappings = FindAll(currentUsername);
            CLOToPLO CLOToPLO = new CLOToPLO();
            if (CLOToPLOMappings != null)
            {
                try
                {
                    CLOToPLOMappings = CLOToPLOMappings.FindAll(CLOToPLOMapping => CLOToPLOMapping.CLO.Id == CLOId);
                    CLOToPLO.CLO = (CLOToPLOMappings.Count > 0) ? CLOToPLOMappings[0].CLO : null;
                    CLOToPLO.MapPLOLists = new List<MapPLO>();

                    foreach (var items in CLOToPLOMappings)
                    {
                        MapPLO mapPLO = new MapPLO()
                        {
                            PLO = items.PLO,
                            Points = items.Points
                        };
                        CLOToPLO.MapPLOLists.Add(mapPLO);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                }
            }
            return CLOToPLO;
        }

        public string Save(CLOToPLOMapping CLOToPLOMapping, string CurrentUsername)
        {
            string message = IsValidCLOToPLOMapping(CLOToPLOMapping, CurrentUsername);
            if (FindById(CLOToPLOMapping.Id, CurrentUsername) == null)
            {
                if (String.IsNullOrEmpty(message))
                {
                    return CLOToPLOMappingRepository.Save(CLOToPLOMapping) ? null : Messages.IssueInDatabase;
                }
                else return Messages.CLONotFound;
            }
            else return Messages.NotFound;
        }

        public string Update(CLOToPLOMapping CLOToPLOMapping, string CurrentUsername)
        {
            string message = IsValidCLOToPLOMapping(CLOToPLOMapping, CurrentUsername);
            if (FindById(CLOToPLOMapping.Id, CurrentUsername) != null)
            {
                if (String.IsNullOrEmpty(message))
                {
                    return CLOToPLOMappingRepository.Update(CLOToPLOMapping) ? null : Messages.IssueInDatabase;
                }
                else return Messages.CLONotFound;
            }
            else return Messages.NotFound;
        }

        private string IsValidCLOToPLOMapping(CLOToPLOMapping CLOToPLOMapping, string currentUsername)
        {
            try
            {
                if (CLOService.FindById(CLOToPLOMapping.CLO.Id, currentUsername) != null)
                {
                    if (PLOService.FindById(CLOToPLOMapping.PLO.Id, currentUsername) != null)
                    {
                        return null;
                    }
                    else return Messages.PLONotFound;
                }
                else return Messages.CLONotFound;
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                return Messages.Issue;
            }
        }

        public CLOToPLOMapping FindById(int id, string CurrentUsername)
        {
            CLOToPLOMapping CLOToPLOMapping = FindAll(CurrentUsername).Find(mtp => mtp.Id == id);
            return CLOToPLOMapping;
        }
    }
}
