using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diesta.MVC.Controllers
{
    public class PartialModalController : Controller
    {
        // GET: PartialModal
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TemelBilgiModal()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult DiyetOykusuModal()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult BesinAliskanlikModal()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult GecmisModal()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult GenelAliskanlikModal()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult HareketModal()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult KisiselModal()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult FinansModal()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult NotModal()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult EgzersizModal()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult AntropometriModal()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult MenuModal()
        {
            return PartialView();
        }
    }
}