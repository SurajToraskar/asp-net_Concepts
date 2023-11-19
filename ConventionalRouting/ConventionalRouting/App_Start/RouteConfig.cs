using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.WebSockets;

namespace ConventionalRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name:"allStudents",
                url:"students",
                defaults: new {controller="Student",action="GetAllStudent"},
                constraints:new {id=@"\d+" }

                );
            routes.MapRoute(
                name: "student",
                url: "student/{id}",
                defaults: new { controller = "Student", action = "GetStudent" }
                );
            routes.MapRoute(
                name:"studentAddress",
                url:"student/{id}/Address",
                defaults:new {controller="Student",action="GetStudentAddress"}f
                );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
