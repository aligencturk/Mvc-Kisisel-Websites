using MvcCv.Proje.Models.Entity;
using MvcCv.Proje.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Proje.Controllers
{
    public class EgitimController : Controller
    {
        // GET: Eğitim
        GenericRepository<TblEgitimlerim> repo = new GenericRepository<TblEgitimlerim>();
        public ActionResult Index()
        {
            var egitim = repo.List();
            if (egitim == null)
            {
                egitim = new List<TblEgitimlerim>();
            }
            return View(egitim);
        }
        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }
        [HttpPost]
        public  ActionResult EgitimEkle(TblEgitimlerim p)
        {
            if(!ModelState.IsValid)
            {
                return View("EgitimEkle");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult EgitimSil(int id)
        {
            var egitim=repo.Find(x=>x.ID == id);
            repo.Tdelete(egitim);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EgitimDuzenle(int id)
        {
            var egitim = repo.Find(x => x.ID == id);
            return View(egitim);
        }
        [HttpPost]
        public ActionResult EgitimDuzenle(TblEgitimlerim t)
        {

            if (!ModelState.IsValid)
            {
                return View("EgitimDuzenle");
            }

            var egitim = repo.Find(x => x.ID == t.ID);
            egitim.Baslik = t.Baslik;
            egitim.AltBaslik = t.AltBaslik;
            egitim.AltBaslik2 = t.AltBaslik2;
            egitim.Tarih = t.Tarih;
            egitim.GNO = t.GNO;
            repo.TUpdate(egitim);
            return RedirectToAction("Index"); 
        }
    }
}