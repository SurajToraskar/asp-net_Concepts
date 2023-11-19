using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagAndViewData.Models;
namespace ViewBagAndViewData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Name = "KingDestroyer";
            ViewBag.myList = new List<string>() { "DBZ", "JJK", "OPM" };
            List<Employee> emp = new List<Employee>() {
                new Employee(){Id=1,Name="KingDestroyer",Email="kingdestroyer@gmail.com"},
                new Employee(){Id=2,Name="GravityDestroyer",Email="gravitydestroyer@gmail.com"},
                new Employee(){Id=3,Name="EvilBeast",Email="evilbeast@gmail.com"}

            };

            ViewBag.myEmployeeList = emp; 


            return View();
        }

        public ActionResult Demo()
        {
            ViewData["My Name"] = "GravityDestroyer";
            ViewData["My List"] = new List<string>() { "Duke", "Bullet", "Pulsor" };
            return View();
        }
    }
}