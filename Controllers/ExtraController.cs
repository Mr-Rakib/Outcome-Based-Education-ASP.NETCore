using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBETools.BLL.Services;
using OBETools.Models;

namespace OBETools.Controllers
{
    [Authorize]
    public class ExtraController : Controller
    {
        private static CLOService CLOService = new CLOService();
        private static AcademicEvaluationService AcademicEvaluationService = new AcademicEvaluationService();

        public JsonResult FindByCLO(int id)
        {
            List<AcademicEvaluation> AcademicEvaluations = new List<AcademicEvaluation>();
            List<AcademicEvaluation> AcademicEvaluationLists = AcademicEvaluationService.FindAll(User.Identity.Name);
            CLO CLO = CLOService.FindById(id, User.Identity.Name);

            AcademicEvaluationLists = AcademicEvaluationLists.FindAll(ae => ae.Course.Id == CLO.Course.Id);
            foreach (var item in AcademicEvaluationLists)
            {
                if (item.Marks > 0)
                {
                    AcademicEvaluations.Add(item);
                }
            }
            return Json(AcademicEvaluations);
        }

        public JsonResult FindByEvaluationId(int id)
        {
            List<CLO> CLOLists = new CLOService().FindAll(User.Identity.Name);
            AcademicEvaluation AcademicEvaluation = AcademicEvaluationService.FindById(id, User.Identity.Name);

            CLOLists = CLOLists.FindAll(cl => cl.Course.Id == AcademicEvaluation.Course.Id);
            return Json(CLOLists);
        }

        public JsonResult FindEvaluationByCourseId(int id, int value)
        {
            List<AcademicEvaluation> AcademicEvaluationList = new List<AcademicEvaluation>();
            List<AcademicEvaluation> AcademicEvaluations = AcademicEvaluationService.FindAll(User.Identity.Name);
            AcademicEvaluations = AcademicEvaluations.FindAll(ae => ae.Course.Id == id && ae.SemesterId == value);

            foreach(var items in AcademicEvaluations)
            {
                if (items.Marks > 0)
                {
                    AcademicEvaluationList.Add(items);
                }
            }
            return Json(AcademicEvaluationList);
        }
    }
}
