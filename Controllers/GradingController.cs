using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using OBETools.BLL.Services;
using OBETools.Models;
using OBETools.Models.View_Model;
using OBETools.Utility;

namespace OBETools.Controllers
{
    public class GradingController : Controller
    {
        private readonly GradingSystemService GradingSystemService = new GradingSystemService();

        public ActionResult Index()
        {
            Grading Grading = new Grading()
            {
                GradingSystems      = GradingSystemService.FindAll(User.Identity.Name),
                AcademicGradings    = new List<AcademicGrading>()
            };
            return View(Grading);
        }

        public ActionResult Details(int id)
        {
            if (id > 0)
            {
                GradingSystem GradingSystem = GradingSystemService.FindById(id, User.Identity.Name);
                return PartialView("Details", GradingSystem);
            }
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GradingSystem GradingSystemList)
        {
            if (ModelState.IsValid)
            {
                string message = GradingSystemService.Save(GradingSystemList, User.Identity.Name);
                TempData["Success"] = message;
                return RedirectToAction("Index");
            }
            else ViewData["Error"] = Messages.InvalidField;
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (id > 0)
            {
                GradingSystem GradingSystem = GradingSystemService.FindById(id, User.Identity.Name);
                return View(GradingSystem);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GradingSystem GradingSystem)
        {
            string message;
            if (ModelState.IsValid)
            {
                message = GradingSystemService.Update(GradingSystem, User.Identity.Name);
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
                message = GradingSystemService.Delete(id, User.Identity.Name);
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
    }
}
