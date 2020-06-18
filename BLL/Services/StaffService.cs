using OBETools.DAL.Repository;
using OBETools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.BLL.Services
{
    public class StaffService
    {
        private readonly StaffRepository StaffRepository = new StaffRepository();
        public string Delete(int Id, string CurrentUsername)
        {
            throw new NotImplementedException();
        }

        public List<Staff> FindAll(string CurrentUsername)
        {
            List<Staff> Staffs = StaffRepository.FindAll();
            return Staffs;
        }

        public Staff FindById(int id, string CurrentUsername)
        {
            Staff Staff = FindAll(CurrentUsername).Find(st => st.Id == id);
            return Staff;
        }

        public string Save(Staff user, string CurrentUsername)
        {
            throw new NotImplementedException();
        }

        public string Update(Staff user, string CurrentUsername)
        {
            throw new NotImplementedException();
        }
    }
}
