using Microsoft.AspNetCore.Localization;
using MoreLinq;
using OBETools.BLL.Interface;
using OBETools.DAL.Repository;
using OBETools.Models;
using OBETools.Models.View_Model;
using OBETools.Utility;
using OBETools.Utility.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace OBETools.BLL.Services
{
    public class AcademicEvaluationService : ICRUD<AcademicEvaluation>
    {
        private AcademicEvaluationRepository AcademicEvaluationRepository = new AcademicEvaluationRepository();
        private AssessmentService AssessmentService = new AssessmentService();
        private CourseService CourseService = new CourseService();

        public string Delete(int Id, string CurrentUsername)
        {
            if (FindById(Id, CurrentUsername) != null)
            {
                return AcademicEvaluationRepository.Delete(Id) ? null : Messages.IssueInDatabase;
            }
            else return Messages.NotFound; 
        }

        public List<AcademicEvaluation> FindAll(string CurrentUsername)
        {
            List<AcademicEvaluation> academicEvaluations = AcademicEvaluationRepository.FindAll();
            foreach(var item in academicEvaluations)
            {
                item.Assessment = AssessmentService.FindById(item.Assessment.Id, CurrentUsername);
                item.Course = CourseService.FindById(item.Course.Id, CurrentUsername);
            }
            return academicEvaluations;
        }


        public List<AcademicEvaluationLists> FindAlls(string CurrentUsername)
        {
            List<AcademicEvaluationLists> AllacademicEvaluationList = new List<AcademicEvaluationLists>();
            List<AcademicEvaluation> academicEvaluations = FindAll(CurrentUsername).DistinctBy(ae => new { ae.Course.Id, ae.SemesterId}).ToList();

            foreach (var item in academicEvaluations)
            {
                AcademicEvaluationLists academicEvaluationLists = GetAcademicEvaluationListByCourseAndSemesterId(item.Course.Id, item.SemesterId, CurrentUsername);
                if (academicEvaluationLists != null)
                {
                    AllacademicEvaluationList.Add(academicEvaluationLists);
                }
            }
            return AllacademicEvaluationList;
        }
        public string SaveAll(AcademicEvaluationLists academicEvaluationList, string name)
        {
            int save = 0, remain = 0;
            foreach (var item in academicEvaluationList.Assessments)
            {
                AcademicEvaluation AcademicEvaluation = new AcademicEvaluation()
                {
                    Assessment = new Assessment()
                    {
                        Id = item.Assessment.Id
                    },
                    Course = new Course()
                    {
                        Id = academicEvaluationList.Course.Id
                    },

                    Marks = item.Marks,
                    SemesterId = academicEvaluationList.SemesterId
                };
                if (string.IsNullOrEmpty(Save(AcademicEvaluation, name)))
                {
                    save++;
                }
                else remain++;
            }
            return String.Concat(save, " Saved & ", remain, " Remains");
        }

        public string UpdateAll(AcademicEvaluationLists academicEvaluationList, string CurrentUsername)
        {
            int update = 0, remain = 0;
            foreach (var item in academicEvaluationList.Assessments)
            {
                AcademicEvaluation AcademicEvaluation = new AcademicEvaluation()
                {
                    Assessment = new Assessment()
                    {
                        Id = item.Assessment.Id
                    },
                    Course = new Course()
                    {
                        Id = academicEvaluationList.Course.Id
                    },

                    Marks = item.Marks,
                    SemesterId = academicEvaluationList.SemesterId
                };

                var x = FindAll(CurrentUsername);

                AcademicEvaluation.Id = x.Find(ae => ae.Course.Id == AcademicEvaluation.Course.Id && ae.Assessment.Id == AcademicEvaluation.Assessment.Id && ae.SemesterId == AcademicEvaluation.SemesterId).Id;
               
                if (string.IsNullOrEmpty(Update(AcademicEvaluation, CurrentUsername)))
                {
                    update++;
                } else remain++;
            }
            return String.Concat(update, " Updated & ", remain, " Remains");
        }

        public AcademicEvaluationLists GetAcademicEvaluationListByCourseAndSemesterId(int id, int semesterId, string CurrentUsername)
        {
            List<AcademicEvaluation> AcademicEvaluations = FindByCourseId(id, semesterId, CurrentUsername);
            AcademicEvaluationLists AcademicEvaluationLists = new AcademicEvaluationLists();
            try
            {
                AcademicEvaluationLists.Course = (AcademicEvaluations.Count > 0) ? AcademicEvaluations[0].Course : null;
                AcademicEvaluationLists.SemesterId = (AcademicEvaluations.Count > 0) ? AcademicEvaluations[0].SemesterId : 0;
                AcademicEvaluationLists.Assessments = new List<MapAssessment>();

                foreach (var items in AcademicEvaluations)
                {
                    MapAssessment MapAssessment = new MapAssessment()
                    {
                        Assessment = items.Assessment,
                        Marks = items.Marks,
                        EntryInformation = items.EntryInformation
                    };
                    AcademicEvaluationLists.Assessments.Add(MapAssessment);
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }

            return AcademicEvaluationLists;
        }

        public AcademicEvaluation FindById(int id, string CurrentUsername)
        {
            AcademicEvaluation academicEvaluation = new AcademicEvaluation();
            academicEvaluation = FindAll(CurrentUsername).Find(ae => ae.Id == id);
            return academicEvaluation;
        }

        public List<AcademicEvaluation> FindByCourseId(int id, int semesterId, string CurrentUsername)
        {
            List<AcademicEvaluation> academicEvaluations = FindAll(CurrentUsername);
            academicEvaluations = academicEvaluations.FindAll(ae => ae.Course.Id == id && ae.SemesterId == semesterId);
            return academicEvaluations;
        }

        public string Save(AcademicEvaluation AcademicEvaluation, string CurrentUsername)
        {
            if(FindById(AcademicEvaluation.Id, CurrentUsername) == null)
            {
                string message = CheckValidity(AcademicEvaluation, CurrentUsername);
                if (string.IsNullOrEmpty(message))
                {
                    if (!IsExist(AcademicEvaluation, CurrentUsername))
                    {
                        AcademicEvaluation.EntryInformation = new EntryInformation()
                        {
                            EntryById = Authorization.GetCurrentUser(CurrentUsername).Id,
                            EntryDate = DateTime.Now
                        };
                        return AcademicEvaluationRepository.Save(AcademicEvaluation) ? null : Messages.IssueInDatabase ;
                    }
                    else return Messages.Exist;
                }
                else return message;
            }
            return Messages.IdExist;
        }

        public string Update(AcademicEvaluation AcademicEvaluation, string CurrentUsername)
        {
            AcademicEvaluation FoundedAcademicEvaluation = FindById(AcademicEvaluation.Id, CurrentUsername);
            if (FoundedAcademicEvaluation != null)
            {
                string message = CheckValidity(AcademicEvaluation, CurrentUsername);
                if (string.IsNullOrEmpty(message))
                {
                    if (IsExist(AcademicEvaluation, CurrentUsername))
                    {
                        AcademicEvaluation.EntryInformation = FoundedAcademicEvaluation.EntryInformation;
                        return AcademicEvaluationRepository.Update(AcademicEvaluation) ? null : Messages.IssueInDatabase;
                    }
                    else return Messages.Exist;
                }
                else return message;
            }
            return Messages.IdExist;
        }
        
        private string CheckValidity(AcademicEvaluation AcademicEvaluation, string CurrentUsername)
        {
            if (CourseService.FindById(AcademicEvaluation.Course.Id, CurrentUsername) != null)
            {
                if (AssessmentService.FindById(AcademicEvaluation.Course.Id, CurrentUsername) != null)
                {
                    return null;
                }
                else return Messages.AssessmentNotFound;
            }
            else return Messages.CourseNotFound;
        }

        private bool IsExist(AcademicEvaluation academicEvaluation, string currentUsername)
        {
            List<AcademicEvaluation> academicEvaluations = FindAll(currentUsername);
            academicEvaluations = academicEvaluations.Where(ae => ae.SemesterId == academicEvaluation.SemesterId && ae.Course.Id == academicEvaluation.Course.Id && ae.Assessment.Id == academicEvaluation.Assessment.Id).ToList();
            return academicEvaluations.Count == 0  ? false : true;
        }

    }
}
