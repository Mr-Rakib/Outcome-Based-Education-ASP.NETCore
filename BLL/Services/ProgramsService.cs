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
    public class ProgramsService : ICRUD<Programs>
    {
        private static ProgramRepository ProgramRepository = new ProgramRepository();
        private static DepartmentService DepartmentService = new DepartmentService();

        public string Delete(int Id, string CurrentUsername)
        {
            Programs Programs = FindById(Id, CurrentUsername);
            if (Programs != null)
            {
                return ProgramRepository.Delete(Id) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }

        public List<Programs> FindAll(string CurrentUsername)
        {
            List<Programs> ProgramsLists = ProgramRepository.FindAll();
            ProgramsLists.ForEach(Program => Program.Department = DepartmentService.FindById(Program.Department.Id, CurrentUsername));
            return ProgramsLists;
        }

        public Programs FindById(int id, string CurrentUsername)
        {
            Programs FoundedPrograms = FindAll(CurrentUsername).Find(Programs => Programs.Id == id);
            return FoundedPrograms;
        }

        public string Save(Programs Programs, string CurrentUsername)
        {
            if (FindById(Programs.Id, CurrentUsername) == null)
            {
                if (DepartmentService.FindById(Programs.Department.Id, CurrentUsername) != null)
                {
                    return ProgramRepository.Save(Programs) ? null : Messages.IssueInDatabase;
                }
                else return Messages.DepartmentNotFound;
            }
            else return Messages.NotFound;
        }

        public string Update(Programs Programs, string CurrentUsername)
        {
            if (FindById(Programs.Id, CurrentUsername) != null)
            {
                if (DepartmentService.FindById(Programs.Department.Id, CurrentUsername) != null)
                {
                    return ProgramRepository.Update(Programs) ? null : Messages.IssueInDatabase;
                }
                else return Messages.DepartmentNotFound;
            }
            else return Messages.NotFound;
        }
    }
}
