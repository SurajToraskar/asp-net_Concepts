using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialView.Models;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee()
                {
                    Id=1,
                    Name="Goku",
                    Email="goku@gmail.com"
                },
                new Employee()
                {
                    Id = 2,
                    Name="Vegeta",
                    Email="vegeta@gmail.com"
                },
                new Employee()
                {
                    Id=3,
                    Name="Broly",
                    Email="broly@gmail.com"
                },
                new Employee()
                {
                    Id=4,
                    Name="Gohan",
                    Email="gohan@gmail.com"
                },
                new Employee()
                {
                    Id=5,
                    Name="Trunks",
                    Email="trunk@gmail.com"
                },
                new Employee()
                {
                    Id=6,
                    Name="Goten",
                    Email="goten@gmail.com"
                }

            };
            return View(emp);
        }
    }
}