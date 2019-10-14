using ProjectDemo.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new MainAppViewModel();
            ViewBag.viewModel = viewModel;
            return View();
        }
        
    }
}