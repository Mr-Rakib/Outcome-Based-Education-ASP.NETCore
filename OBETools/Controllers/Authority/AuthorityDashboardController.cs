using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBETools.BLL.Services;
using OBETools.Models;

namespace OBETools.Controllers.Authority
{
    public class AuthorityDashboardController : Controller
    {
        // GET: AuthorityDashboard
        public ActionResult Index()
        {
            List<Login> logins = new LoginService().GetAllLogin();
            return View(logins);
        }

        // GET: AuthorityDashboard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AuthorityDashboard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorityDashboard/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorityDashboard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuthorityDashboard/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorityDashboard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuthorityDashboard/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}