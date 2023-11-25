using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stronglyTypedHtmlHelper.Models;

namespace stronglyTypedHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            Employee employee = new Employee()
            {
                Name = "KingDestroyer",
                Address = "Whole World",
                Id = 007
            };
            return View(employee);
        }
    }
}