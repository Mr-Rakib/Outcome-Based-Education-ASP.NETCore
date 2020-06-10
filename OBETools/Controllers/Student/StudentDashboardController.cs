using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OBETools.Controllers.Student
{
    public class StudentDashboardController : Controller
    {
        // GET: StudentDashboard
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudentDashboard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentDashboard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentDashboard/Create
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

        // GET: StudentDashboard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentDashboard/Edit/5
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

        // GET: StudentDashboard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentDashboard/Delete/5
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