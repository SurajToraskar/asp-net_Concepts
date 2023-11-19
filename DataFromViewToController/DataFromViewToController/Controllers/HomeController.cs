using DataFromViewToController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataFromViewToController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string PostUsingParameters(string firstName,string lastName)
        {
            return $"From Parameters firstName - {firstName} lastName - {lastName}";
        }
        [HttpPost]
        public string PostUsingRequest()
        {
            string firstName = Request["firstName"];
            string lastName = Request["lastName"];
            return $"From Request firstName - {firstName} lastName - {lastName}";
        }
        [HttpPost]
        public string PostUsingFormCollection(FormCollection form)
        {
            string firstName = form["firstName"];
            string lastName = form["lastName"];
            return $"From FormCollection firstName - {firstName} lastName - {lastName}";
        }

        [HttpPost]
        public string PostUsingStronglyBinding(Employee emp)
        {
            return $"From Strongly Binding firstName - {emp.FirstName} lastName - {emp.LastName}";
        }
    }
}