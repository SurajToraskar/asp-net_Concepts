using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            TempData["myKey"] = "Data from Index";
            return View();
        }
        public ActionResult Index2()
        {
            ViewBag.myValue = TempData.Peek("myKey");
            return View();
        }
        public ActionResult Index3()
        {
            ViewBag.myValue = TempData["myKey"];
            return View();
        }
        public ActionResult Index4()
        {
            return View();
        }
    }
}