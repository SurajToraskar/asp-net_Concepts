using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ajax_BeginForm_In_MVC.Models;
using Newtonsoft.Json;

namespace Ajax_BeginForm_In_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
      
        public JsonResult Index(Employee employee)
        {

            return Json("true",JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult List()
        {
            return View();
        }

        public JsonResult Countries()
        {
            List<String> countries = new List<String>()
            {
                "Afghanistan",
                "Albania",
                "Algeria",
                "Andorra",
                "Angola",
                "Antigua and Barbua",
                "Argentina",
                "Armenia",
                "Australia",
                "Austria",
                "Azerbaijan",
                "The Bahamas",
                "Bahrain",
                "Bangladesh",
                "Barbados"

            };

            var json=JsonConvert.SerializeObject(countries);
            return Json(json,JsonRequestBehavior.AllowGet);
        }

        public JsonResult States  ()
        {

            List<string> states = new List<string>()
            {
                "Goa",
                "Maharashtra",
                "Delhi",
                "Mumbai",
                "Bihar"

            };

            var json = JsonConvert.SerializeObject(states);
            return Json(json,JsonRequestBehavior.AllowGet);
        }

        public JsonResult City()
        {
            List<String> city = new List<String>()
            {
                "Vasco",
                "Panjim",
                "Margao",
                
            };
            var json = JsonConvert.SerializeObject(city);
            return Json(json,JsonRequestBehavior.AllowGet);
        }
    }
}