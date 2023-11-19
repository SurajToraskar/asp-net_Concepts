using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["myKey"] = "Data From Index";
            return View();
        }
        public ActionResult Index2()
        {
            ViewBag.myValue = TempData["myKey"];
            TempData.Keep();
            return View();
        }
        public ActionResult Index3()
        {
            ViewBag.myValue = TempData["myKey"];
            return View();
        }public ActionResult Index4()
        {
            ViewBag.myValue = TempData["myKey"];
            return View();
        }
    }
}