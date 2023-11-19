using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRouting.Models;
namespace AttributeRouting.Controllers
{
    [RoutePrefix("students")]
    public class StudentController : Controller
    {
        // GET: Student
        [Route("")]
        public ActionResult GetAllStudents()
        {
            var students = Students();
            return View(students);
        }

        [Route("{id:int:min(1)}")]
       public ActionResult GetStudent(int id)
        {
            var student = Students().FirstOrDefault(x => x.Id == id);
            return View(student);
        }

        [Route("{id}/Address")]
        public ActionResult GetStudentAddress(int id)
        {
            var  getStudentAddress=Students().Where(x=>x.Id==id).Select(x=>x.Address).FirstOrDefault();
            return View(getStudentAddress);
        }

        [Route("{id}")]
        public String displayId(String id)
        {
            return id;
        }

        //~ overides the routeprefix
        [Route("~/about-us")]
        [Route("~/aboutus")]
        public string About()
        {
            return "About Us Page";
        }

        private List<Student> Students()
        {
            return new List<Student>
            {
                new Student
                {
                    Name="Goku",
                    Age=22,
                    Id=1,
                    Address=new Address()
                    {
                        Address1="Baina",
                        City="Vasco",
                        HomeNumber=890899
                    }
                }, new Student
                {
                    Name="Vegeta",
                    Age=22,
                    Id=2,
                    Address=new Address()
                    {
                        Address1="Trister",
                        City="Panjim",
                        HomeNumber=00009
                    }
                }, new Student
                {
                    Name="Broly",
                    Age=22,
                    Id=3,
                    Address=new Address()
                    {
                        Address1="Vaddem",
                        City="Vasco",
                        HomeNumber=8900999
                    }
                },
                
            };
        }
    }
}