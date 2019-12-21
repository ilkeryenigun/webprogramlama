using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProgramlamaProjesi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Anasayfa()
        {
            return View();
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }

        public ActionResult Programlar()
        {
            return View();
        }

        public ActionResult Etkinlikler()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }
    }
}