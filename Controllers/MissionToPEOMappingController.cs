using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBETools.BLL.Services;
using OBETools.Models;
using OBETools.Models.View_Model;
using OBETools.Utility;

namespace OBETools.Controllers
{
    public class MissionToPEOMappingController : Controller
    {
        public MissionToPEOMappingService MissionToPEOMappingService = new MissionToPEOMappingService();

        public ActionResult Index()
        {
            List<MissionToPEO> MissionToPEOs = MissionToPEOMappingService.FindAllMissionToPEO(User.Identity.Name);
            return View(MissionToPEOs);
        }

        public ActionResult Details(int id)
        {
            if (id > 0)
            {
                MissionToPEO MissionToPEOMapping = MissionToPEOMappingService.FindByMissionId(id, User.Identity.Name);
                return PartialView("Partial/Details", MissionToPEOMapping);
            }
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MissionToPEO MissionToPEO)
        {
            if (ModelState.IsValid)
            {
                string message = MissionToPEOMappingService.SaveMapping(MissionToPEO, User.Identity.Name);
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
        public ActionResult Edit(int id)
        {
            if (id > 0)
            {
                MissionToPEO MissionToPEO = MissionToPEOMappingService.FindByMissionId(id, User.Identity.Name);
                return View(MissionToPEO);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MissionToPEO MissionToPEO)
        {
            string message;
            if (ModelState.IsValid)
            {
                message = MissionToPEOMappingService.UpdateMapping(MissionToPEO, User.Identity.Name);
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

        public ActionResult Delete(int id)
        {
            string message;
            if (id > 0)
            {
                message = MissionToPEOMappingService.Delete(id, User.Identity.Name);
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