using OBETools.DAL.Repository;
using OBETools.Models;
using OBETools.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.BLL.Services
{
    public class GradingSystemService
    {
        private static GradingSystemRepository GradingSystemRepository = new GradingSystemRepository();

        public string Delete(int Id, string CurrentUsername)
        {
            GradingSystem GradingSystem = FindById(Id, CurrentUsername);
            if (GradingSystem != null)
            {
                return GradingSystemRepository.Delete(Id) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }

        public List<GradingSystem> FindAll(string CurrentUsername)
        {
            List<GradingSystem> GradingSystemLists = GradingSystemRepository.FindAll();
            return GradingSystemLists;
        }

        public GradingSystem FindById(int id, string CurrentUsername)
        {
            GradingSystem FoundedGradingSystem = FindAll(CurrentUsername).Find(GradingSystem => GradingSystem.Id == id);
            return FoundedGradingSystem;
        }

        public string Save(GradingSystem GradingSystem, string CurrentUsername)
        {
            if (FindById(GradingSystem.Id, CurrentUsername) == null)
            {
                return GradingSystemRepository.Save(GradingSystem) ? null : Messages.IssueInDatabase;
            }
            else return Messages.Exist;
        }

        public string Update(GradingSystem GradingSystem, string CurrentUsername)
        {
            if (FindById(GradingSystem.Id, CurrentUsername) != null)
            {
                return GradingSystemRepository.Update(GradingSystem) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }
    }
}
