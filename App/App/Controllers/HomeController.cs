using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Models;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            List<Employee> lstEmployee = new List<Employee>();

            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });
            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });
            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });
            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });
            lstEmployee.Add(new Employee() { Name = "admin1", Address = "Bản đồ Tp HCM, bản đồ các quận, map tphcm mới nhất", Birthday = DateTime.Now });

            ViewData["employee"] = lstEmployee;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
