using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trial1.Models;

namespace Trial1.Controllers
{
    public class TrialController : Controller
    {
        // GET: Trial
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult Display()
        {
            var data = Employee();
            return View(data);
        }
        private Data Employee()
        {
            return new Data()
            {
                Id = 12,
                Name = "KingDestroyer",
                Address = "India"
            };
        }
    }
}