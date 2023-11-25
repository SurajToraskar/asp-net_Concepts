using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trial1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public string EmployeeProfile(int id)
        {
            string profile = String.Empty;
            if (id == 1)
            {

                profile = "Employee 1 found";
            }else if (id == 2)
            {
                profile = "Employee6 2 found";
            }
            else
            {
                profile = "Data Not Found";
            }
            return profile;
        }
        public string  Address(int id,int? code)
        {
            return $"id = {id} and code = {code}";
        }
    }
}