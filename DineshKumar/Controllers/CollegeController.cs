using DineshKumar.Models;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

namespace DineshKumar.Controllers
{
    public class CollegeController : Controller
    {
        private readonly DatabaseContext m;

        public CollegeController(DatabaseContext a) 
        {
            m = a;
        }
      
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(College a)
        {
            if(!ModelState.IsValid)
            {
                TempData["a"] = "ModelState is not valid";
            }
            try
            {
                m.StaffsDetails.Add(a);
                m.SaveChanges();
                TempData["a"] = "Value added succesfully";
                return RedirectToAction("Create");
            }
            catch (Exception ex)
            {
                return View( ex.Message) ;
            }
        }
       
        public IActionResult Read()
        {
            var StaffDetails = m.StaffsDetails.ToList();
            return View(StaffDetails);
        }
     
        public IActionResult Update(int id)
        {
            var st = m.StaffsDetails.Find(id);
            return View(st);
        }
        [HttpPost]
        public IActionResult Update(College a)
        {
            if(!ModelState.IsValid)
            {
                TempData["a"] = "ModelState is not vaild";
                return View();
            }
            try
            {
                m.StaffsDetails.Update(a);
                m.SaveChanges();
                TempData["a"] = "Updated Succesfully";
                return RedirectToAction("Read");
            }
            catch (Exception ex)
            {
                return View(ex.Message) ;
            }
        }
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
