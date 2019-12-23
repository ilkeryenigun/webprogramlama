using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Globalization;

namespace WebProgramlamaProjesi.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Degistir(string diluzanti)
        {
            if (diluzanti != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(diluzanti);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(diluzanti);
            }
            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = diluzanti;
            Response.Cookies.Add(cookie);
            return View("Index");
        }
    }
}