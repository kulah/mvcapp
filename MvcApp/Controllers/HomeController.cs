﻿using MvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        ibkyazilimContext dbconntext = new ibkyazilimContext();
        public ActionResult Index()
        {
            Session["Kullanici"] = "İbrahim KÜLAH";
            return View();
        }
        public ActionResult KullanicilariListele ()
        {
            return View(dbconntext.USERLISTs.ToList());
        }
    }
}
