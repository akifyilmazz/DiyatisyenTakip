using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diesta.MVC.Controllers
{
    public class FinansController : Controller
    {
        // GET: Finans
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FinansList()
        {
            return View();
        }
    }
}