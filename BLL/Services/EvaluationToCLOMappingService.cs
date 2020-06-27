using OBETools.DAL.Repository;
using OBETools.Models;
using OBETools.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.BLL.Services
{
    public class EvaluationToCLOMappingService
    {
        private static EvaluationToCLOMappingRepository EvaluationToCLOMappingRepository = new EvaluationToCLOMappingRepository();
        private static AcademicEvaluationService AcademicEvaluationService = new AcademicEvaluationService();
        private static CLOService CLOService = new CLOService();

        public string Delete(int Id, string CurrentUsername)
        {
            EvaluationToCLOMapping EvaluationToCLOMapping = FindById(Id, CurrentUsername);
            if (EvaluationToCLOMapping != null)
            {
                return EvaluationToCLOMappingRepository.Delete(Id) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound;
        }

        public List<EvaluationToCLOMapping> FindAll(string CurrentUsername)
        {
            List<EvaluationToCLOMapping> EvaluationToCLOMappingLists = EvaluationToCLOMappingRepository.FindAll();
            EvaluationToCLOMappingLists.ForEach(etcm => etcm.AcademicEvaluation = FindEvaluation(etcm.AcademicEvaluation.Id, CurrentUsername));
            EvaluationToCLOMappingLists.ForEach(etcm => etcm.CLO = FindCLO(etcm.CLO.Id, CurrentUsername));
            return EvaluationToCLOMappingLists;
        }

        private CLO FindCLO(int id, string currentUsername)
        {
            CLO CLO = new CLO();
            CLO = CLOService.FindById(id, currentUsername);
            return CLO;
        }

        private AcademicEvaluation FindEvaluation(int id, string currentUsername)
        {
            AcademicEvaluation academicEvaluation = new AcademicEvaluation();
            academicEvaluation = AcademicEvaluationService.FindById(id, currentUsername);
            return academicEvaluation;
        }

        public EvaluationToCLOMapping FindById(int id, string CurrentUsername)
        {
            EvaluationToCLOMapping FoundedEvaluationToCLOMapping = FindAll(CurrentUsername).Find(EvaluationToCLOMapping => EvaluationToCLOMapping.Id == id);
            return FoundedEvaluationToCLOMapping;
        }

        public string Save(EvaluationToCLOMapping EvaluationToCLOMapping, string CurrentUsername)
        {
            if (FindById(EvaluationToCLOMapping.Id, CurrentUsername) == null)
            {
                if (FindEvaluation(EvaluationToCLOMapping.AcademicEvaluation.Id, CurrentUsername) != null)
                {
                    if (FindCLO(EvaluationToCLOMapping.CLO.Id, CurrentUsername) != null)
                    {
                        return EvaluationToCLOMappingRepository.Save(EvaluationToCLOMapping) ? null : Messages.IssueInDatabase;
                    }
                    else return Messages.CLONotFound;
                }
                else return Messages.AssessmentNotFound;
            }
            else return Messages.Exist;
        }

        public string Update(EvaluationToCLOMapping EvaluationToCLOMapping, string CurrentUsername)
        {
            if (FindById(EvaluationToCLOMapping.Id, CurrentUsername) != null)
            {
                if (FindEvaluation(EvaluationToCLOMapping.AcademicEvaluation.Id, CurrentUsername) != null)
                {
                    if (FindCLO(EvaluationToCLOMapping.CLO.Id, CurrentUsername) != null)
                    {
                        return EvaluationToCLOMappingRepository.Save(EvaluationToCLOMapping) ? null : Messages.IssueInDatabase;
                    }
                    else return Messages.CLONotFound;
                }
                else return Messages.AssessmentNotFound;
            }
            else return Messages.Exist;
        }
    }
}
