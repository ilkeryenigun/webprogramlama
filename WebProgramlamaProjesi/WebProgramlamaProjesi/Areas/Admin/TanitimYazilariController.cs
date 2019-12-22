using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProgramlamaProjesi.Areas.Admin
{
    public class TanitimYazilariController : Controller
    {
        TerapiEntities db = new TerapiEntities();
        // GET: Admin/TanitimYazilari
        public ActionResult Index()
        {
            return View();
        }
    }
}