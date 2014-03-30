using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class ApiController : Controller
    {
        //
        // GET: /Api/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Api/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Api/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Api/Create

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

        //
        // GET: /Api/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Api/Edit/5

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

        //
        // GET: /Api/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Api/Delete/5

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
