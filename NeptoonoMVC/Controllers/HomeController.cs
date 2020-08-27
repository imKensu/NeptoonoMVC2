using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NeptoonoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Todos nuestros datos de contacto.";
            ViewBag.Calle = "Procasa 3 Casa 18.";
            ViewBag.Lugar = "Buenos Aires, Argentina";
            ViewBag.Telefono = "0303-456";

            return View();
        }
    }
}