using WebProgramlamaProjesi.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace WebProgramlamaProjesi.Areas.Admin
{
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {

        TerapiEntities db = new TerapiEntities();
        // GET: Admin/Slider
        public ActionResult Index()
        {
            var model = db.Slider.OrderByDescending(x => x.SliderID).ToList();
           return View(model);
        }
        public ActionResult Ekle()
        {
            return View();
        }
        const string imageFolderPath = "/Content/slider-images/";
        public ActionResult SliderEkle(SliderModel model)
        {
            if (ModelState.IsValid)
            {
                string fileName = string.Empty;
                //Dosya kaydetme
                if (model.Resim!=null &&model.Resim.ContentLength>0) {
                    fileName = model.Resim.FileName;
                    var path= Path.Combine(Server.MapPath("~"+imageFolderPath),fileName);
                    model.Resim.SaveAs(path);
                }
                //EF nesnesi oluştur
                Slider slider = new Slider();
                slider.BaslangicTarih = model.BaslangicTarih;
                slider.BitisTarih = model.BitisTarih;
                slider.SliderBaslik = model.SliderBaslik;
                slider.SliderAciklama = model.SliderAciklama;
                slider.SliderResimYolu = imageFolderPath+fileName;
                slider.SliderID = model.SliderID;

                db.Slider.Add(slider);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Slider.Find(id);
            
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Slider model)
        {
            if (ModelState.IsValid)
            {
                db.Slider.Attach(model);
                db.Entry(model).State=System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model=db.Slider.Find(id);
            return View(model);
        }
        [HttpGet]
        public ActionResult DeleteConfirm(int id)
        {
            var model = db.Slider.Find(id);
            db.Slider.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index") ;
        }

    }
}