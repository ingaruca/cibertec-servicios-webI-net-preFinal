using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class NegociosController : Controller
    {
        ServiceController serv = new ServiceController();

        // GET: Negocios
        public ActionResult Index()
        {
            return View(serv.Get());
        }

        public ActionResult Create()
        {
            ViewBag.caracteristicas = new SelectList(serv.GetCarcteristica(), "idCar", "desCar");
            return View(new Herramienta());
        }

        [HttpPost]

        public ActionResult Create(Herramienta h)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.caracteristicas = new SelectList(serv.GetCarcteristica(), "idCar", "desCar");
                return View(h);
            }

            serv.Post(h);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            Herramienta h = serv.Get(id);
            ViewBag.caracteristicas = new SelectList(serv.GetCarcteristica(), "idCar", "desCar", h.idCar);
            return View(h);
        }

        [HttpPost]

        public ActionResult Edit(Herramienta h)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.caracteristicas = new SelectList(serv.GetCarcteristica(), "idCar", "desCar", h.idCar);
                return View(h);
            }

            serv.Put(h);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            serv.Delete(id);

            return RedirectToAction("Index");
        }

        public ActionResult Details(string id)
        {
            return View(serv.Get(id));
        }
    }
}