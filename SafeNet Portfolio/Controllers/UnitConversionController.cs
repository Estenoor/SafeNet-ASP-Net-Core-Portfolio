using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SafeNet_Portfolio.Controllers
{
    public class UnitConversionController : Controller
    {
        // GET: UnitConversion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult JavaScript()
        {
            return View("JavaScript");
        }

        public ActionResult MvcServer()
        {
            return View("MvcServer");
        }
    }
}