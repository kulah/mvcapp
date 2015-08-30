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
        [HttpPost]
        public string UyeGirisi()
        {
            //Request.Form["html elementinin name özelliği"] ile Post edilen formdaki elemanların
            //değerlerini alabiliyoruz. Bu metod yalnızca Post ile çalışır.
            string posta = Request.Form["txtPosta"];
            string sifre = Request.Form["pswSifre"];
            if (String.IsNullOrEmpty(posta) && String.IsNullOrEmpty(sifre))
            {
                return "E-Posta adresinizi ve şifrenizi girmediniz.";
            }
            else if (String.IsNullOrEmpty(posta))
            {
                return "E-posta adresinizi girmediniz.";
            }
            else if (string.IsNullOrEmpty(sifre))
            {
                return "Şifrenizi girmediniz.";
            }
            else
            {
                using (ibkyazilimContext db = new ibkyazilimContext())
                {
                    //Normalde şifreyi hashleyerek yazdırmamız ve kontrol etmemiz gerekir.
                    var uye = (from i in db.USERLISTs where i.password == sifre && i.email == posta select i).SingleOrDefault();

                    if (uye == null) return "Kullanıcı adınızı ya da şifreyi hatalı girdiniz.";

                    //Session'da müşteri ile ilgili bilgileri saklamaktayız.
                    //Güvenlik açısından bilgileri şifreleyerek saklamamız daha doğru bir yöntemdir.
                    //Asp.Net Membership yapısı, bu güvenliği sunmaktadır.
                    Session["uyeId"] = uye.id;

                    //Burada eğer, kullanıcı bilgileri, sistemde eşleşirse, geriye girişin başarılı
                    //olduğuna dair bir mesaj ve 3 saniye sonra, ana sayfaya yönlendirecek bir
                    //javascript kodu ekliyoruz.
                    return "Sisteme, başarıyla giriş yaptınız.<script type='text/javascript'>setTimeout(function(){window.location='/'},3000);</script>";
                }
            }
        }

    }
}
