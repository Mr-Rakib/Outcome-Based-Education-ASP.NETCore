using OBETools.DAL.Repository;
using OBETools.Models;
using OBETools.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.BLL.Services
{
    public class CLOService
    {
        private static CourseService CourseService = new CourseService();
        private static CLORepository CLORepository = new CLORepository();

        public string Delete(int Id, string CurrentUsername)
        {
            CLO CLO = FindById(Id, CurrentUsername);
            if (CLO != null)
            {
                return CLORepository.Delete(Id) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }

        public List<CLO> FindAll(string CurrentUsername)
        {
            List<CLO> CLOLists = CLORepository.FindAll();
            CLOLists.ForEach(CLO => CLO.Course = CourseService.FindById(CLO.Course.Id, CurrentUsername));
            return CLOLists;
        }

        public CLO FindById(int id, string CurrentUsername)
        {
            CLO FoundedCLO = FindAll(CurrentUsername).Find(CLO => CLO.Id == id);
            return FoundedCLO;
        }

        public string Save(CLO CLO, string CurrentUsername)
        {
            if (FindById(CLO.Id, CurrentUsername) == null)
            {
                if (CourseService.FindById(CLO.Course.Id, CurrentUsername) != null)
                {
                    return CLORepository.Save(CLO) ? null : Messages.IssueInDatabase;
                }
                else return Messages.CourseNotFound;
            }
            else return Messages.NotFound;
        }

        public string Update(CLO CLO, string CurrentUsername)
        {
            if (FindById(CLO.Id, CurrentUsername) != null)
            {
                if (CourseService.FindById(CLO.Course.Id, CurrentUsername) != null)
                {
                    return CLORepository.Update(CLO) ? null : Messages.IssueInDatabase;
                }
                else return Messages.CourseNotFound;
            }
            else return Messages.NotFound;
        }

    }
}
