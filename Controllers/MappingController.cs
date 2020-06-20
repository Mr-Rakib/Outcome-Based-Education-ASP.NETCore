using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBETools.BLL.Services;
using OBETools.Models.View_Model;
using OBETools.Utility;

namespace OBETools.Controllers
{
    [Authorize]
    public class MappingController : Controller
    {
        private readonly MissionToPEOMappingService MissionToPEOMappingService = new MissionToPEOMappingService();
        private readonly PLOToPEOMappingService PLOToPEOMappingService = new PLOToPEOMappingService();
        private readonly CLOToPLOMappingService CLOToPLOMappingService = new CLOToPLOMappingService();

        ///------------------------ ALL MAPPING -------------------------------///
        public ActionResult Index()
        {
            Mapping Mapping = new Mapping();
            Mapping.MissionToPEOs = new List<MissionToPEO>();
            Mapping.PLOToPEOs = new List<PLOToPEO>();
            Mapping.CLOToPLOs = new List<CLOToPLO>();

            Mapping.MissionToPEOs = MissionToPEOMappingService.FindAllMissionToPEO(User.Identity.Name);
            Mapping.PLOToPEOs = PLOToPEOMappingService.FindAllPLOToPEO(User.Identity.Name);
            Mapping.CLOToPLOs = CLOToPLOMappingService.FindAllCLOToPLO(User.Identity.Name);
            return View(Mapping);
        }

        /// --------------------- MISSION TO PEO ------------------------------///
        public ActionResult MissionToPEODetails(int id)
        {
            if (id > 0)
            {
                MissionToPEO MissionToPEOMapping = MissionToPEOMappingService.FindByMissionId(id, User.Identity.Name);
                return PartialView("Partial/MissionToPEODetails", MissionToPEOMapping);
            }
            return View();
        }

        public ActionResult MissionToPEOCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MissionToPEOCreate(MissionToPEO MissionToPEO)
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
        public ActionResult MissionToPEOEdit(int id)
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
        public ActionResult MissionToPEOEdit(MissionToPEO MissionToPEO)
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

        public ActionResult MissionToPEODelete(int id)
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

        /// -------------------------------- PLO TO PEO ------------------------------------ ///

        public ActionResult PLOToPEODetails(int id)
        {
            if (id > 0)
            {
                PLOToPEO PLOToPEOMapping = PLOToPEOMappingService.FindByPLOId(id, User.Identity.Name);
                return PartialView("Partial/PLOToPEODetails", PLOToPEOMapping);
            }
            return View();
        }

        public ActionResult PLOToPEOCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PLOToPEOCreate(PLOToPEO PLOToPEO)
        {
            if (ModelState.IsValid)
            {
                string message = PLOToPEOMappingService.SaveMapping(PLOToPEO, User.Identity.Name);
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
        public ActionResult PLOToPEOEdit(int id)
        {
            if (id > 0)
            {
                PLOToPEO PLOToPEO = PLOToPEOMappingService.FindByPLOId(id, User.Identity.Name);
                return View(PLOToPEO);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PLOToPEOEdit(PLOToPEO PLOToPEO)
        {
            string message;
            if (ModelState.IsValid)
            {
                message = PLOToPEOMappingService.UpdateMapping(PLOToPEO, User.Identity.Name);
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

        public ActionResult PLOToPEODelete(int id)
        {
            string message;
            if (id > 0)
            {
                message = PLOToPEOMappingService.Delete(id, User.Identity.Name);
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

        /// -------------------------------- CLO TO PLO ------------------------------------ ///

        public ActionResult CLOToPLODetails(int id)
        {
            if (id > 0)
            {
                CLOToPLO CLOToPLOMapping = CLOToPLOMappingService.FindByCLOId(id, User.Identity.Name);
                return PartialView("Partial/CLOToPLODetails", CLOToPLOMapping);
            }
            return View();
        }

        public ActionResult CLOToPLOCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CLOToPLOCreate(CLOToPLO CLOToPLO)
        {
            if (ModelState.IsValid)
            {
                string message = CLOToPLOMappingService.SaveMapping(CLOToPLO, User.Identity.Name);
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
        public ActionResult CLOToPLOEdit(int id)
        {
            if (id > 0)
            {
                CLOToPLO CLOToPLO = CLOToPLOMappingService.FindByCLOId(id, User.Identity.Name);
                return View(CLOToPLO);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CLOToPLOEdit(CLOToPLO CLOToPLO)
        {
            string message;
            if (ModelState.IsValid)
            {
                message = CLOToPLOMappingService.UpdateMapping(CLOToPLO, User.Identity.Name);
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

        public ActionResult CLOToPLODelete(int id)
        {
            string message;
            if (id > 0)
            {
                message = CLOToPLOMappingService.Delete(id, User.Identity.Name);
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