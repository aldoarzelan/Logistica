using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logistica.Controllers
{
    public class DestinoController : Controller
    {
        // GET: Destino
        public ActionResult Destino()
        {
            return View("Destino");
        }
        
        public ActionResult Index()
        {
            return View();
        }
          
        // GET: Destino/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Destino/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Destino/Create
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

        // GET: Destino/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        //Prueba DestinoController
        // POST: Destino/Edit/5
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

        // GET: Destino/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Destino/Delete/5
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
