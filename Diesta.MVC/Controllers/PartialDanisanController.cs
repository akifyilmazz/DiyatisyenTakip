using Diesta.MVC.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Diesta.MVC.Class.Hesapla;

namespace Diesta.MVC.Controllers
{
    public class PartialDanisanController : Controller
    {
        // GET: PartialDanisan
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DanisanBilgiTemel()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult DiyetOykusu()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult BesinAliskanlik()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult Gecmis()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult GenelAliskanlik()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult Hareket()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult Kisisel()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult Antropometri()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult Egzersiz()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult Finans()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult Not()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult BMIHesapla(Hesapla.BMI bMIHesapla)
        {
            Hesapla.BMI BMIGonder = new BMI();
            
            BMIGonder.boy = bMIHesapla.boy/100;

            BMIGonder.kilo = bMIHesapla.kilo;

            BMIGonder.index = bMIHesapla.kilo / (BMIGonder.boy * BMIGonder.boy);

            return Json(BMIGonder);
        }
    }
}