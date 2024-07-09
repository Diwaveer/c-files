using Microsoft.AspNetCore.Mvc;
using MVC_DB.Models;
using System.Diagnostics;

namespace MVC_DB.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult   Add()
        {

            return View();
        }
      
        public IActionResult Privacy()
        {

            ViewBag.a = "Addedd Successfully  ..!!";
            ViewData["a1"] = "Addedd Successfully  ..!!";
            TempData["a1"] = "Addedd Successfully  ..!!";
            return View();
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
