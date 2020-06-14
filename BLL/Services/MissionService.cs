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
    public class MissionService : ICRUD<Mission>
    {
        private static MissionRepository MissionRepository = new MissionRepository();

        public string Delete(int Id, string CurrentUsername)
        {
            Mission mission = FindById(Id, CurrentUsername);
            if (mission != null)
            {
                return MissionRepository.Delete(Id) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }

        public List<Mission> FindAll(string CurrentUsername)
        {
            List<Mission> MissionLists = MissionRepository.FindAll();
            return MissionLists;
        }

        public Mission FindById(int id, string CurrentUsername)
        {
            Mission FoundedMission = FindAll(CurrentUsername).Find(mission => mission.Id == id);
            return FoundedMission;
        }

        public string Save(Mission mission, string CurrentUsername)
        {
            if (FindById(mission.Id, CurrentUsername) == null)
            {
                return MissionRepository.Save(mission) ? null : Messages.IssueInDatabase;
            }
            else return Messages.Exist;
        }

        public string Update(Mission mission, string CurrentUsername)
        {
            if (FindById(mission.Id, CurrentUsername) != null)
            {
                return MissionRepository.Update(mission) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }
    }
}
