using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConventionalRouting.Models;

namespace ConventionalRouting.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetAllStudent()
        {
            var students = Students();
            return View(students);
        }
        public ActionResult GetStudent(int id)
        {
            var student = Students().FirstOrDefault(x => x.Id == id);
            return View(student);

        }
        public ActionResult GetStudentAddress(int id)
        {
            var studentAddress = Students().Where(x => x.Id == id).Select(x => x.Address).FirstOrDefault();
            return View(studentAddress);
        }
        private List<Student> Students()
        {
            return new List<Student>()
            {
                new Student()
                {
                Id=1,
                Name="Goku",
                Class="First",
                Address=new Address()
                {
                    Address1="This is student 1 address ",
                    City="Vasco",
                    HomeNumber=975555544
                }
                },
                new Student()
                {
                    Id=2,
                    Name="Vegeta",
                    Class="Second",
                    Address=new Address()
                    {
                        Address1="This is student 2 address",
                        City="Panjim",
                        HomeNumber=894895790
                    }
                }
               


            };
        }
    }
}