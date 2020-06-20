using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBETools.BLL.Services;
using OBETools.Models;
using OBETools.Utility;

namespace OBETools.Controllers
{
    [Authorize]
    public class AcademyController : Controller
    {
        private readonly MissionService MissionService = new MissionService();
        private readonly PEOService PEOService = new PEOService();
        private readonly PLOService PLOService = new PLOService();
        private readonly CLOService CLOService = new CLOService();


        public ActionResult Index()
        {
            List<Mission> MissionList = MissionService.FindAll(User.Identity.Name);
            List<PEO> PEOList = PEOService.FindAll(User.Identity.Name);
            List<PLO> PLOList = PLOService.FindAll(User.Identity.Name);
            List<CLO> CLOList = CLOService.FindAll(User.Identity.Name);
            Academy Academy = new Academy()
            {
                Missions = MissionList,
                PEOs = PEOList,
                PLOs = PLOList,
                CLOs = CLOList
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
                    TempData["Error"] = Messages.Deleted;
                    return RedirectToAction("Index");
                }
                else ViewData["Warning"] = message;
            }
            else ViewData["Warning"] = Messages.InvalidField;
            return View();
        }

        // -------------- PEO ----------
        public ActionResult DetailsPEO(int id)
        {
            if (id > 0)
            {
                PEO PEO = PEOService.FindById(id, User.Identity.Name);
                return PartialView("Partial/PEODetails", PEO);
            }
            return View();
        }

        public ActionResult CreatePEO()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePEO(PEO PEO)
        {
            if (ModelState.IsValid)
            {
                string message = PEOService.Save(PEO, User.Identity.Name);
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
        public ActionResult EditPEO(int id)
        {
            if (id > 0)
            {
                PEO PEO = PEOService.FindById(id, User.Identity.Name);
                return View(PEO);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPEO(PEO PEO)
        {
            string message;
            if (ModelState.IsValid)
            {
                message = PEOService.Update(PEO, User.Identity.Name);
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

        public ActionResult DeletePEO(int id)
        {
            string message;
            if (id > 0)
            {
                message = PEOService.Delete(id, User.Identity.Name);
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

        // -------------- PLO ----------
        public ActionResult DetailsPLO(int id)
        {
            if (id > 0)
            {
                PLO PLO = PLOService.FindById(id, User.Identity.Name);
                return PartialView("Partial/PLODetails", PLO);
            }
            return View();
        }

        public ActionResult CreatePLO()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePLO(PLO PLO)
        {
            if (ModelState.IsValid)
            {
                string message = PLOService.Save(PLO, User.Identity.Name);
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
        public ActionResult EditPLO(int id)
        {
            if (id > 0)
            {
                PLO PLO = PLOService.FindById(id, User.Identity.Name);
                return View(PLO);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPLO(PLO PLO)
        {
            string message;
            if (ModelState.IsValid)
            {
                message = PLOService.Update(PLO, User.Identity.Name);
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

        public ActionResult DeletePLO(int id)
        {
            string message;
            if (id > 0)
            {
                message = PLOService.Delete(id, User.Identity.Name);
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

        // -------------- CLO ----------
        public ActionResult DetailsCLO(int id)
        {
            if (id > 0)
            {
                CLO CLO = CLOService.FindById(id, User.Identity.Name);
                return PartialView("Partial/CLODetails", CLO);
            }
            return View();
        }

        public ActionResult CreateCLO()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCLO(CLO CLO)
        {
            if (ModelState.IsValid)
            {
                string message = CLOService.Save(CLO, User.Identity.Name);
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
        public ActionResult EditCLO(int id)
        {
            if (id > 0)
            {
                CLO CLO = CLOService.FindById(id, User.Identity.Name);
                return View(CLO);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCLO(CLO CLO)
        {
            string message;
            if (ModelState.IsValid)
            {
                message = CLOService.Update(CLO, User.Identity.Name);
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

        public ActionResult DeleteCLO(int id)
        {
            string message;
            if (id > 0)
            {
                message = CLOService.Delete(id, User.Identity.Name);
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