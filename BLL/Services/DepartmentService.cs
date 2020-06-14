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
    public class DepartmentService : ICRUD<Departments>
    {
        private static DepartmentRepository DepartmentsRepository = new DepartmentRepository();

        public string Delete(int Id, string CurrentUsername)
        {
            Departments Departments = FindById(Id, CurrentUsername);
            if (Departments != null)
            {
                return DepartmentsRepository.Delete(Id) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }

        public List<Departments> FindAll(string CurrentUsername)
        {
            List<Departments> DepartmentsLists = DepartmentsRepository.FindAll();
            return DepartmentsLists;
        }

        public Departments FindById(int id, string CurrentUsername)
        {
            Departments FoundedDepartments = FindAll(CurrentUsername).Find(Departments => Departments.Id == id);
            return FoundedDepartments;
        }

        public string Save(Departments Departments, string CurrentUsername)
        {
            if (FindById(Departments.Id, CurrentUsername) == null)
            {
                return DepartmentsRepository.Save(Departments) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }

        public string Update(Departments Departments, string CurrentUsername)
        {
            if (FindById(Departments.Id, CurrentUsername) != null)
            {
                return DepartmentsRepository.Update(Departments) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }
    }
}
