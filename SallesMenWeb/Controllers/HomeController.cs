using Microsoft.AspNetCore.Mvc;
using SallesMenWeb.Models.ViewModels;
using SallesMenWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SallesMenWeb.Controllers
{
    public class HomeController : Controller // inherits Controller class
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sales Men Web";
            ViewData["Who:"] = "Danilo Pereira";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
