using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diesta.MVC.Controllers
{
    public class DanisanController : Controller
    {
        // GET: Danisan
        
        public ActionResult DanisanList()
        {
            return View();
        }
        public ActionResult DanisanEkle()
        {
            return View();
        }

    }
}