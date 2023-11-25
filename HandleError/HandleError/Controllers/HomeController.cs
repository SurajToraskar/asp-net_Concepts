using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandleError.Controllers
{
    //[HandleError]
    public class HomeController : Controller
    {
        // GET: Home
      //  [HandleError]
        public ActionResult Index()
        {
            throw new Exception("Error");
            return View();
        }
      //  [HandleError]
        public ActionResult About()
        {
            throw new Exception("About Error");
            return View();
        }
    }
}