using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProgramlamaProjesi.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class YonetimController : Controller
    {
        TerapiEntities db = new TerapiEntities();
        // GET: Admin/Yonetim
        public ActionResult Index()
        {
            return View();
        }

    }
}