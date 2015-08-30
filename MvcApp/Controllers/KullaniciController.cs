using MvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class KullaniciController : Controller
    {
        //
        // GET: /Kullanici/
        ibkyazilimContext dbconntext = new ibkyazilimContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UyeGiris()
        {
            return View();
        }
        
    }
}
