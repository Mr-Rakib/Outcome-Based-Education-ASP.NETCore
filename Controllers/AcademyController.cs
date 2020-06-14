using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBETools.BLL.Services;
using OBETools.Models;
using OBETools.Utility;

namespace OBETools.Controllers
{
    public class AcademyController : Controller
    {
        private readonly MissionService MissionService = new MissionService();
        private readonly PEOService PEOService = new PEOService();
        private readonly PLOService PLOService = new PLOService();


        public ActionResult Index()
        {
            List<Mission> MissionList = MissionService.FindAll(User.Identity.Name);
            List<PEO> PEOList = PEOService.FindAll(User.Identity.Name);
            List<PLO> PLOList = PLOService.FindAll(User.Identity.Name);
            Academy Academy = new Academy()
            {
                Missions = MissionList,
                PEOs = PEOList,
                PLOs = PLOList
            };
            return View(Academy);
        }

        public ActionResult DetailsMission(int id)
        {
            if (id > 0)
            {
                Mission Mission = MissionService.FindById(id, User.Identity.Name);
                return PartialView("Partial/MissionDetails",Mission);
            }
            return View();
        }

        public ActionResult CreateMission()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMission(Mission mission)
        {
            if (ModelState.IsValid)
            {
                string message = MissionService.Save(mission, User.Identity.Name);
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
        public ActionResult EditMission(int id)
        {
            if (id > 0)
            {
                Mission Mission = MissionService.FindById(id, User.Identity.Name);
                return View(Mission);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditMission(Mission Mission)
        {
            string message;
            if (ModelState.IsValid)
            {
                message = MissionService.Update(Mission, User.Identity.Name);
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

        public ActionResult DeleteMission(int id)
        {
            string message;
            if (id>0)
            {
                message = MissionService.Delete(id, User.Identity.Name);
                if (String.IsNullOrEmpty(message))
                {
                    TempData["Success"] = Messages.Deleted;
                    return RedirectToAction("Index");
                }
                else ViewData["Warning"] = message;
            }
            else ViewData["Warning"] = Messages.InvalidField;
            return View();
        }

    }
}