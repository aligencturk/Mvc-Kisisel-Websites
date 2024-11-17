using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Proje.Models.Entity;

namespace MvcCv.Proje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCVEntities db = new DbCVEntities();
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult Eğitimlerim()

        {
            var egitimler = db.TblEgitimlerim.ToList();
            return PartialView(egitimler);
        }
        public PartialViewResult Yeteneklerim()

        {
            var yetenekler = db.TblYeteneklerim.ToList();
            return PartialView(yetenekler);
        }

        public PartialViewResult Hobilerim()


        {
            var Hobiler = db.TblHobilerim.ToList();
            return PartialView(Hobiler);
        }
        public PartialViewResult Sertifikalarım()


        {
            var sertifikalar = db.TblSertifikalar.ToList();
            return PartialView(sertifikalar);
        }
        [HttpGet]
        public PartialViewResult iletisim()

         
        {

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(Tbliletişim t)


        {
            t.Tarih=DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbliletişim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}