using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logistica.Controllers
{
    public class DestinatarioController : Controller
    {
        // GET: Destinatario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Destinatario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Destinatario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Destinatario/Create
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

        // GET: Destinatario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Destinatario/Edit/5
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

        // GET: Destinatario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Destinatario/Delete/5
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
