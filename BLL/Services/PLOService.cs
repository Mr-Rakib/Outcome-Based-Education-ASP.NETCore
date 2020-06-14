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
    public class PLOService : ICRUD<PLO>
    {
        private static PLORepository PLORepository = new PLORepository();
        private static ProgramsService ProgramsService = new ProgramsService();

        public string Delete(int Id, string CurrentUsername)
        {
            PLO PLO = FindById(Id, CurrentUsername);
            if (PLO != null)
            {
                return PLORepository.Delete(Id) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }

        public List<PLO> FindAll(string CurrentUsername)
        {
            List<PLO> PLOLists = PLORepository.FindAll();
            PLOLists.ForEach(PLO => PLO.Program = ProgramsService.FindById(PLO.Program.Id, CurrentUsername));
            return PLOLists;
        }

        public PLO FindById(int id, string CurrentUsername)
        {
            PLO FoundedPLO = FindAll(CurrentUsername).Find(PLO => PLO.Id == id);
            return FoundedPLO;
        }

        public string Save(PLO PLO, string CurrentUsername)
        {
            if (FindById(PLO.Id, CurrentUsername) == null)
            {
                if (ProgramsService.FindById(PLO.Program.Id, CurrentUsername) != null)
                {
                    return PLORepository.Save(PLO) ? null : Messages.IssueInDatabase;
                }
                else return Messages.ProgramNotFound;
            }
            else return Messages.NotFound;
        }

        public string Update(PLO PLO, string CurrentUsername)
        {
            if (FindById(PLO.Id, CurrentUsername) != null)
            {
                if (ProgramsService.FindById(PLO.Program.Id, CurrentUsername) != null)
                {
                    return PLORepository.Update(PLO) ? null : Messages.IssueInDatabase;
                }
                else return Messages.ProgramNotFound;
            }
            else return Messages.NotFound;
        }
    }
}
