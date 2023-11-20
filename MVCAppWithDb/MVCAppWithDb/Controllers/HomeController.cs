using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Db.DbOperations;
using MyApp.Model;
namespace MVCAppWithDb.Controllers
{
    public class HomeController : Controller
    {
        EmployeeRepository repository = null;
        // GET: Home
        public HomeController()
        {
            repository = new EmployeeRepository();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        {
             if(ModelState.IsValid)
            {
              int id=  repository.AddEmployee(model);
                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.IsSuccess = "Data Added";
                }
            }
            return View();
        }
          
        public ActionResult GetAllRecords()
        {
            var result = repository.GetAllEmployee();
            return View(result);
        }

        public ActionResult Details(int id)
        {
            var employee = repository.GetEmployee(id);
            return View(employee);
        }

        public ActionResult Edits(int id)
        {
            var employee = repository.GetEmployee(id);
            return View(employee);
        }

        [HttpPost]

        public ActionResult Edits(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                repository.UpdateEmployee(model.Id,model);
                return RedirectToAction("GetAllRecords");
            }

            return View();
        }
        public string TestMethod()
        {
            return repository.GetAllEmployee().ToString();
        }
    }
}