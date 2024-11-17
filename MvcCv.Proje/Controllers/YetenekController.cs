using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Proje.Models.Entity;
using MvcCv.Proje.Controllers;
using MvcCv.Proje.Repositories;

namespace MvcCv.Proje.Controllers
{
    public class YetenekController : Controller
    {
        // GET: Yetenek
       
        GenericRepository<TblYeteneklerim> repo = new GenericRepository<TblYeteneklerim>();
        public ActionResult Index()
        {
            var yetenekler = repo.List();
            return View(yetenekler);
        }
    }
}