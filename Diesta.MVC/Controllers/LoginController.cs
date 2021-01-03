using Diesta.MVC.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diesta.MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        public ActionResult Login()
        {
            
            
            return View();
        }
        [HttpPost]
        public ActionResult Login(GirisModel login)
        {
            var hata = "";
            if (login.eposta != "akif@gmail.com" || login.password != "1234")
            {
                hata = "Kullanıcı Adı Veya Şifre Yanlış";
            }
           

            return Json(hata);
        }

        public ActionResult Register()
        {
            return View();
        }
        
    }
}