using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProgramlamaProjesi.Areas.Admin
{
    public class SliderController : Controller
    {

        TerapiEntities db = new TerapiEntities();
        // GET: Admin/Slider
        public ActionResult Index()
        {
            var model = db.Slider.OrderByDescending(x => x.SliderID).ToList();
            return View();
        }
        public ActionResult Ekle()
        {
            return View();
        }

    }
}