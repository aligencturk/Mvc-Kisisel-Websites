using MvcCv.Proje.Models.Entity;
using MvcCv.Proje.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Proje.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        GenericRepository<TblHakkimda> repo = new GenericRepository<TblHakkimda>();
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            if (hakkimda == null)
            {
                hakkimda = new List<TblHakkimda>();
            }
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(TblHakkimda p)
        {
            //TblHobilerim t = new TblHobilerim();
            var t = repo.Find(x => x.ID == 1);
            t.Ad = p.Ad;
            t.Soyad = p.Soyad;
            t.Adres = p.Adres;
            t.Mail = p.Mail;
            t.Telefon = p.Telefon;
            t.Aciklama = p.Aciklama;
            t.Resim = p.Resim;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}