using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProfessionalNetwork.Controllers
{
    public class InterviewController : Controller
    {
        // GET: Interview
        public ActionResult Index()
        {
            return View();
        }

        // GET: Interview/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Interview/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Interview/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Interview/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Interview/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Interview/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Interview/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
