using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab3.Models;

namespace Lab3.Controllers
{
    public class PlantillaController : Controller
    {
        // GET: Plantilla
        public ActionResult Boleta()
        {
            return View(new Haberes());
        }
        [HttpPost]public ActionResult Boleta(Haberes reg)
        {
            ViewBag.Bonificacion = reg.Bonificacion();
            ViewBag.Remuneracion = reg.Remuneracion();
            ViewBag.Aportacion = reg.Aportacion();
            ViewBag.Neto = reg.Neto();
            return View(reg);
        }
    }
}