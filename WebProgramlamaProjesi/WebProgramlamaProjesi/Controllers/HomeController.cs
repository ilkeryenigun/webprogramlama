using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProgramlamaProjesi.Controllers
{
    public class HomeController : Controller
    {
        TerapiEntities db = new TerapiEntities();
        public ActionResult Index()
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

        [Authorize(Roles = "Kullanici")]
        public ActionResult Iletisim()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult _Slider()
        {
            var model = db.Slider.OrderByDescending(x => x.SliderID).ToList();
            return View(model);
        }
        [ChildActionOnly]
        public ActionResult _TanitimYazilari()
        {
            var model = db.TanitimYazilari.OrderBy(x => x.TanitimID).ToList();
            return View(model);
        }
        [ChildActionOnly]
        public ActionResult _OrnekYazi()
        {
            var model = db.OrnekYazi.OrderBy(x => x.OrnekYaziID).ToList();
            return View(model);
        }
        [ChildActionOnly]
        public ActionResult _Programlar()
        {
            var model = db.Programlar.OrderBy(x => x.ProgramID).ToList();
            return View(model);
        }
        [ChildActionOnly]
        public ActionResult _Ogretmenler()
        {
            var model = db.Ogretmenler.OrderBy(x => x.OgretmenID).ToList();
            return View(model);
        }
    }
}