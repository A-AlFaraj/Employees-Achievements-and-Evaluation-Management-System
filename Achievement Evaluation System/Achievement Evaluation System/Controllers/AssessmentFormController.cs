using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Achievement_Evaluation_System.Controllers
{
    public class AssessmentFormController : Controller
    {
        // GET: AssessmentForm
        public ActionResult Index()
        {
            return View();
        }

        // GET: AssessmentForm/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AssessmentForm/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssessmentForm/Create
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

        // GET: AssessmentForm/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AssessmentForm/Edit/5
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

        // GET: AssessmentForm/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AssessmentForm/Delete/5
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
