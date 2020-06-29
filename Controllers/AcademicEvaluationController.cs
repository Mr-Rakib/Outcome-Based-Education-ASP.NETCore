using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBETools.BLL.Services;
using OBETools.Models;
using OBETools.Models.View_Model;
using OBETools.Utility;

namespace OBETools.Controllers
{
    [Authorize]
    public class AcademicEvaluationController : Controller
    {
        private readonly EvaluationToCLOMappingService EvaluationToCLOMappingService = new EvaluationToCLOMappingService();
        private readonly AcademicEvaluationService AcademicEvaluationService = new AcademicEvaluationService();

        public ActionResult Index()
        {
            List<EvaluationToCLOMapping> EvaluationToCLOMapping = EvaluationToCLOMappingService.FindAll(User.Identity.Name);
            List<AcademicEvaluationLists> AcademicEvaluationLists  = AcademicEvaluationService.FindAlls(User.Identity.Name);
            EvaluationWithMapping evaluationWithMapping = new EvaluationWithMapping() 
            {
                EvaluationToCLOMappings = EvaluationToCLOMapping,
                AcademicEvaluationLists = AcademicEvaluationLists
            };
            return View(evaluationWithMapping);
        }

        public ActionResult Details(int id, int value)
        {
            int semesterId = value;
            if (id > 0)
            {
                AcademicEvaluationLists AcademicEvaluationLists = AcademicEvaluationService.GetAcademicEvaluationListByCourseAndSemesterId(id, semesterId, User.Identity.Name);
                return View("Details", AcademicEvaluationLists);
            }
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AcademicEvaluationLists academicEvaluationList)
        {
            if (ModelState.IsValid)
            {
                string message = AcademicEvaluationService.SaveAll(academicEvaluationList, User.Identity.Name);
                TempData["Success"] = message;
                return RedirectToAction("Index");
            }
            else ViewData["Error"] = Messages.InvalidField;
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id, int value)
        {
            if (id > 0)
            {
                AcademicEvaluationLists AcademicEvaluationLists = AcademicEvaluationService.GetAcademicEvaluationListByCourseAndSemesterId(id, value, User.Identity.Name);
                return View(AcademicEvaluationLists);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AcademicEvaluationLists AcademicEvaluationLists)
        {
            string message;
            if (ModelState.IsValid)
            {
                message = AcademicEvaluationService.UpdateAll(AcademicEvaluationLists, User.Identity.Name);
                TempData["Success"] = message;
                return RedirectToAction("Index");
            }
            else ViewData["Warning"] = Messages.InvalidField;
            return View();
        }

        public ActionResult Delete(int id)
        {
            string message;
            if (id > 0)
            {
                message = AcademicEvaluationService.Delete(id, User.Identity.Name);
                if (String.IsNullOrEmpty(message))
                {
                    TempData["Error"] = Messages.Deleted;
                    return RedirectToAction("Index");
                }
                else ViewData["Warning"] = message;
            }
            else ViewData["Warning"] = Messages.InvalidField;
            return View();
        }
        ///---------------------------------EVALUATION TO CLO MAPPING----------------------------------------///


        public ActionResult EvaluationToCLODetails(int id)
        {
            if (id > 0)
            {
                EvaluationToCLOMapping EvaluationToCLOMapping = EvaluationToCLOMappingService.FindById(id, User.Identity.Name);
                return PartialView("Partial/EvaluationToCLODetails", EvaluationToCLOMapping);
            }
            return View();
        }

        public ActionResult CreateEvaluationToCLOMapping()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEvaluationToCLOMapping(EvaluationToCLOMapping EvaluationToCLOMapping)
        {
            if (ModelState.IsValid)
            {
                string message = EvaluationToCLOMappingService.Save(EvaluationToCLOMapping, User.Identity.Name);
                if (string.IsNullOrEmpty(message))
                {
                    TempData["Success"] = Messages.Created;
                    return RedirectToAction("Index");
                }
                else ViewData["Warning"] = message;
            }
            else ViewData["Error"] = Messages.InvalidField;
            return View();
        }

        [HttpGet]
        public ActionResult EditEvaluationToCLOMapping(int id)
        {
            if (id > 0)
            {
                EvaluationToCLOMapping EvaluationToCLOMapping = EvaluationToCLOMappingService.FindById(id, User.Identity.Name);
                return View(EvaluationToCLOMapping);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditEvaluationToCLOMapping(EvaluationToCLOMapping EvaluationToCLOMapping)
        {
            string message;
            if (ModelState.IsValid)
            {
                message = EvaluationToCLOMappingService.Update(EvaluationToCLOMapping, User.Identity.Name);
                if (String.IsNullOrEmpty(message))
                {
                    TempData["Success"] = Messages.Updated;
                    return RedirectToAction("Index");
                }
                else ViewData["Warning"] = message;
            }
            else ViewData["Warning"] = Messages.InvalidField;
            return View(EvaluationToCLOMapping);
        }

        public ActionResult DeleteEvaluationToCLOMapping(int id)
        {
            string message;
            if (id > 0)
            {
                message = EvaluationToCLOMappingService.Delete(id, User.Identity.Name);
                if (String.IsNullOrEmpty(message))
                {
                    TempData["Error"] = Messages.Deleted;
                    return RedirectToAction("Index");
                }
                else ViewData["Warning"] = message;
            }
            else ViewData["Warning"] = Messages.InvalidField;
            return View();
        }


    }
}
