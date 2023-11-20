using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutInMVC.Controllers
{
    public class EmployeeController : Controller
    {
        [Route("GetEmployee")]
        // GET: Employee
        public ActionResult GetEmployee()
        {
            return View();
        }
        [Route("AddEmployee")]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [Route("DeleteEmployee")]
        public ActionResult DeleteEmployee()
        {
            return View("DeleteEmployee", "~/Views/Shared/_NewLayout.cshtml");
        }
    }
}