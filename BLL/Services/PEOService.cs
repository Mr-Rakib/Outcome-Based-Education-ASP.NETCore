using OBETools.BLL.Interface;
using OBETools.DAL.Repository;
using OBETools.Models;
using OBETools.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.BLL.Services
{
    public class PEOService : ICRUD<PEO>
    {
        private static PEORepository PEORepository = new PEORepository();
        private static ProgramsService ProgramsService = new ProgramsService();

        public string Delete(int Id, string CurrentUsername)
        {
            PEO PEO = FindById(Id, CurrentUsername);
            if (PEO != null)
            {
                return PEORepository.Delete(Id) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }

        public List<PEO> FindAll(string CurrentUsername)
        {
            try
            {
                List<PEO> PEOLists = PEORepository.FindAll();
                PEOLists.ForEach(peo => peo.Program = ProgramsService.FindById(peo.Program.Id, CurrentUsername));
                return PEOLists;
            }catch(Exception ex)
            {
                Logger.Log(ex);
                return null;
            }
        }

        public PEO FindById(int id, string CurrentUsername)
        {
            PEO FoundedPEO = FindAll(CurrentUsername).Find(PEO => PEO.Id == id);
            return FoundedPEO;
        }

        public string Save(PEO PEO, string CurrentUsername)
        {
            if (FindById(PEO.Id, CurrentUsername) == null)
            {
                if (ProgramsService.FindById(PEO.Program.Id, CurrentUsername) != null)
                {
                    return PEORepository.Save(PEO) ? null : Messages.IssueInDatabase;
                }
                else return Messages.ProgramNotFound;
            }
            else return Messages.NotFound;
        }

        public string Update(PEO PEO, string CurrentUsername)
        {
            if (FindById(PEO.Id, CurrentUsername) != null)
            {
                if (ProgramsService.FindById(PEO.Program.Id, CurrentUsername) != null)
                {
                    return PEORepository.Update(PEO) ? null : Messages.IssueInDatabase;
                }
                else return Messages.ProgramNotFound;
            }
            else return Messages.NotFound;
        }
    }
}
