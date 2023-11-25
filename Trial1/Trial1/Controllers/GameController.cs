using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trial1.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }
        public string Name(string name)
        {
            return $"Welcome to {name}";
        }
        public string FullName(String first, String last)
        {
            string statement = string.Empty;
            if (!string.IsNullOrEmpty(first) && !string.IsNullOrEmpty(last))
            {
                statement = $"Your FirstName is {first} and LastName is {last} ";
            }
            else if (!string.IsNullOrEmpty(first))
            {
                statement = $"Your FirstName is {first}";
            } else if (!string.IsNullOrEmpty(last))
            {
                statement = $"Your LastName is {last}";
            }
            return statement;
        }
    }
}