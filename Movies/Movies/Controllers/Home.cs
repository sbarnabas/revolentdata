using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class Home : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
    }
}
