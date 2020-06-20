using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OBETools.BLL.Services;
using OBETools.Models;
using OBETools.Utility;

namespace OBETools.Controllers
{
    [Authorize]
    public class AssessmentController : Controller
    {
        private readonly AssessmentService AssessmentService = new AssessmentService();

        public ActionResult Index()
        {
            List<Assessment> AssessmentList = AssessmentService.FindAll(User.Identity.Name);
            return View(AssessmentList);
        }

        public ActionResult DetailsAssessment(int id)
        {
            if (id > 0)
            {
                Assessment Assessment = AssessmentService.FindById(id, User.Identity.Name);
                return PartialView("Partial/AssessmentDetails", Assessment);
            }
            return View();
        }

        public ActionResult CreateAssessment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAssessment(Assessment Assessment)
        {
            if (ModelState.IsValid)
            {
                string message = AssessmentService.Save(Assessment, User.Identity.Name);
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
        public ActionResult EditAssessment(int id)
        {
            if (id > 0)
            {
                Assessment Assessment = AssessmentService.FindById(id, User.Identity.Name);
                return View(Assessment);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditAssessment(Assessment Assessment)
        {
            string message;
            if (ModelState.IsValid)
            {
                message = AssessmentService.Update(Assessment, User.Identity.Name);
                if (String.IsNullOrEmpty(message))
                {
                    TempData["Success"] = Messages.Updated;
                    return RedirectToAction("Index");
                }
                else ViewData["Warning"] = message;
            }
            else ViewData["Warning"] = Messages.InvalidField;
            return View();
        }

        public ActionResult DeleteAssessment(int id)
        {
            string message;
            if (id > 0)
            {
                message = AssessmentService.Delete(id, User.Identity.Name);
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
