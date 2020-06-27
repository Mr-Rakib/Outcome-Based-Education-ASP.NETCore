using OBETools.DAL.Repository;
using OBETools.Models;
using OBETools.Utility;
using OBETools.Utility.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.BLL.Services
{
    public class AssessmentService
    {
        private static AssessmentRepository AssessmentRepository = new AssessmentRepository();

        public string Delete(int Id, string CurrentUsername)
        {
            Assessment Assessment = FindById(Id, CurrentUsername);
            if (Assessment != null)
            {
                return AssessmentRepository.Delete(Id) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }

        public List<Assessment> FindAll(string CurrentUsername)
        {
            List<Assessment> AssessmentLists = AssessmentRepository.FindAll();
            return AssessmentLists;
        }


        public Assessment FindById(int id, string CurrentUsername)
        {
            Assessment FoundedAssessment = FindAll(CurrentUsername).Find(Assessment => Assessment.Id == id);
            return FoundedAssessment;
        }

        public string Save(Assessment Assessment, string CurrentUsername)
        {
            if (FindById(Assessment.Id, CurrentUsername) == null)
            {
                Assessment.EntryInformation = new EntryInformation()
                {
                    EntryById = Authorization.GetCurrentUser(CurrentUsername).Id,
                    EntryDate = DateTime.Now
                };
                return AssessmentRepository.Save(Assessment) ? null : Messages.IssueInDatabase;
            }
            else return Messages.Exist;
        }

        public string Update(Assessment Assessment, string CurrentUsername)
        {
            Assessment FoundedAssessment = FindById(Assessment.Id, CurrentUsername);
            if (FoundedAssessment != null)
            {
                Assessment.EntryInformation = FoundedAssessment.EntryInformation;
                return AssessmentRepository.Update(Assessment) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }
    }
}
