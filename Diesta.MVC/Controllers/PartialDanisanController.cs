using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}