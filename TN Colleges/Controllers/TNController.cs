using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TN_Colleges.Models;

namespace TN_Colleges.Controllers
{
    public class TNController : Controller
    {
        private readonly ApplicationDbContext d;
        public TNController(ApplicationDbContext a)
        {
            d= a;
        }
        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Create(State_Colleges a)
        {
            if (!ModelState.IsValid)
            {
                TempData["a"] = "Values Not added";
            }
            try
            {
                d.CollegeDetails.Add(a);
                d.SaveChanges();
                TempData["a"] = "Valus added sucessfully";
                return RedirectToAction("Create");

            }
            catch (Exception ex)
            {
                TempData["a"] = ex.Message;
                return View(a);
            }
        }
        public IActionResult Read()
        {
            var CollegeDetails = d.CollegeDetails.ToList();
            return View(CollegeDetails);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
