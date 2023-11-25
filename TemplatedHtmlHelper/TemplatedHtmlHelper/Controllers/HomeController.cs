using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplatedHtmlHelper.Models;

namespace TemplatedHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                Id = 007,
                Name = "KingDestroyer",
                Email="kingdestroyer@gmail.com",
                IsOnline=true,
                DateOfBirth=DateTime.Now,

            };

            return View(emp);
        }
        public ActionResult Edit()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Edit(Employee emp1)
        {

            return View();
        }
    }
}