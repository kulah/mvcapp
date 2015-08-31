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
        ibkyazil_mssqlContext dbconntext = new ibkyazil_mssqlContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(FormCollection form)
        {
            ibkyazil_mssqlContext db = new ibkyazil_mssqlContext();
            USERLIST model = new USERLIST();
            model.username= form["kadi"].Trim();
            model.email = form["email"].Trim();
            model.password = form["sifre"].Trim();
            model.adsoyad = form["adisoyadi"].Trim();
            model.durum = "+";
            db.USERLISTs.Add(model);
            db.SaveChanges();
            return View();
        }


        public ActionResult UyeGiris()
        {
            return View();
        }
        
    }
}
