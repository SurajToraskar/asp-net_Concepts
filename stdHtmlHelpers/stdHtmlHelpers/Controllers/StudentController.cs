﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stdHtmlHelpers.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index(string name)
        {
            return View();
        }
    }
}