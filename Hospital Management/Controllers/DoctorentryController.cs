using Hospital_Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management.Controllers
{
    public class DoctorentryController : Controller
    {
        private readonly DatabaseContext n;
        public DoctorentryController(DatabaseContext b)
        {
            n= b;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Doctor_entry b)
        {
            if (!ModelState.IsValid)
            {
                TempData["a"] = "Modelstate is not valid";
            }
            try
            {
                n.DoctorDetails.Add(b);
                n.SaveChanges();
                TempData["a"] = "Value added succesfully";
                return RedirectToAction("Create");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
        public IActionResult Read()
        {
            var doctorDetails = n.DoctorDetails.ToList();
            return View(doctorDetails);
        }
        [HttpGet]
        public IActionResult Update(string id)
        {
            var st = n.DoctorDetails.Find(id);
            return View(st);
        }
        [HttpPost]
        public IActionResult Update(Doctor_entry b)
        {
            if (!ModelState.IsValid)
            {
                TempData["a"] = "modelstate is not valid";
                return View();
            }
            try
            {
                n.DoctorDetails.Update(b);
                n.SaveChanges();
                TempData["a"] = "Value added succesfully";
                return RedirectToAction("Read");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
        public IActionResult Delete(string id)
        {
            var st = n.DoctorDetails.Find(id);
            n.DoctorDetails.Remove(st);
            n.SaveChanges();
            return RedirectToAction("Read");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
