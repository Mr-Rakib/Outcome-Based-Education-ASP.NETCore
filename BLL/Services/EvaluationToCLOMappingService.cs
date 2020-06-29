using Microsoft.AspNetCore.Localization;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using OBETools.DAL.Repository;
using OBETools.Models;
using OBETools.Utility;
using OBETools.Utility.Dependency;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            string message = IsValidator(EvaluationToCLOMapping, CurrentUsername);
            if (FindById(EvaluationToCLOMapping.Id, CurrentUsername) == null)
            {
                if (string.IsNullOrEmpty(message))
                {
                    EvaluationToCLOMapping = SetValues(EvaluationToCLOMapping, CurrentUsername);
                    if (! IsExist(EvaluationToCLOMapping, CurrentUsername))
                    {
                        EvaluationToCLOMapping.EntryInformation = new EntryInformation()
                        {
                            EntryById = Authorization.GetCurrentUser(CurrentUsername).Id,
                            EntryDate = DateTime.Now
                        };
                        return EvaluationToCLOMappingRepository.Save(EvaluationToCLOMapping) ? null : Messages.IssueInDatabase;
                    }
                    else return Messages.Exist;
                }
                else return message;
            }
            else return Messages.Exist;
        }

        public string Update(EvaluationToCLOMapping EvaluationToCLOMapping, string CurrentUsername)
        {
            EvaluationToCLOMapping FoundedEvaluationToCLOMapping = FindById(EvaluationToCLOMapping.Id, CurrentUsername);
            EvaluationToCLOMapping.EntryInformation = FoundedEvaluationToCLOMapping.EntryInformation;
            string message = IsValidator(EvaluationToCLOMapping, CurrentUsername);

            if (FoundedEvaluationToCLOMapping != null)
            {
                if (string.IsNullOrEmpty(message))
                {
                    EvaluationToCLOMapping = SetValues(EvaluationToCLOMapping, CurrentUsername);
                    if (! IsExistUpdate(EvaluationToCLOMapping, CurrentUsername))
                    {
                        return EvaluationToCLOMappingRepository.Update(EvaluationToCLOMapping) ? null : Messages.IssueInDatabase;
                    }
                    else return Messages.NotFound;
                }
                else return message;
            }
            else return Messages.Exist;
        }

        private bool IsExistUpdate(EvaluationToCLOMapping evaluationToCLOMapping, string currentUsername)
        {
            List<EvaluationToCLOMapping> EvaluationToCLOMappingLists = FindAll(currentUsername).Where(etc => etc.AcademicEvaluation.Id != evaluationToCLOMapping.Id).ToList();
            if (evaluationToCLOMapping != null)
            {
                EvaluationToCLOMappingLists = EvaluationToCLOMappingLists
                    .FindAll(em => em.AcademicEvaluation.Id == evaluationToCLOMapping.AcademicEvaluation.Id &&
                                    em.AcademicEvaluation.SemesterId == evaluationToCLOMapping.AcademicEvaluation.SemesterId &&
                                    em.CLO.Id == evaluationToCLOMapping.CLO.Id
                             );
                return (EvaluationToCLOMappingLists.Count > 0) ? true : false;
            }
            else return false;
        }

        private string IsValidator(EvaluationToCLOMapping EvaluationToCLOMapping, string CurrentUsername)
        {
            if (FindEvaluation(EvaluationToCLOMapping.AcademicEvaluation.Id, CurrentUsername) != null)
            {
                if (FindCLO(EvaluationToCLOMapping.CLO.Id, CurrentUsername) != null)
                {
                    return null;
                }
                else return Messages.CLONotFound;
            }
            else return Messages.AssessmentNotFound;
        }
        private EvaluationToCLOMapping SetValues(EvaluationToCLOMapping evaluationToCLOMapping, string currentUsername)
        {
            evaluationToCLOMapping.AcademicEvaluation = AcademicEvaluationService.FindById(evaluationToCLOMapping.AcademicEvaluation.Id, currentUsername);
            evaluationToCLOMapping.CLO = CLOService.FindById(evaluationToCLOMapping.CLO.Id, currentUsername);
            
            return evaluationToCLOMapping;
        }

        private bool IsExist(EvaluationToCLOMapping evaluationToCLOMapping, string currentUsername)
        {
            List<EvaluationToCLOMapping> EvaluationToCLOMappingLists = FindAll(currentUsername);
            if (evaluationToCLOMapping != null)
            {
                EvaluationToCLOMappingLists = EvaluationToCLOMappingLists
                    .FindAll(em => em.AcademicEvaluation.Id == evaluationToCLOMapping.AcademicEvaluation.Id &&
                                    em.AcademicEvaluation.SemesterId == evaluationToCLOMapping.AcademicEvaluation.SemesterId &&
                                    em.CLO.Id == evaluationToCLOMapping.CLO.Id
                             );
                return (EvaluationToCLOMappingLists.Count > 0) ? true : false;
            }
            else return false;
        }

    }
}
