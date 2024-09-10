using GitExample1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GitExample1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        int count = 200;
        string name = "HCL Technologies"
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return Content("Index Method -Updated");
        }

        public IActionResult Privacy()
        {
            return Content("Privacy Method -Updated");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //public IActionResult Login()
        //{
        //    return View();
        //}
    }
}
