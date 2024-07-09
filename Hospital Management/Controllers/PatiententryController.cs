using Hospital_Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management.Controllers
{
    public class PatiententryController : Controller
    {
        private readonly DatabaseContext m;
        public PatiententryController(DatabaseContext a)
        {
            m = a;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Patient_entry a)
        {
            if(!ModelState.IsValid)
            {
                TempData["a"] = "Modelstate is not valid";             
            }
            try
            {
                m.PatientDetails.Add(a);
                m.SaveChanges();
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
            var PatientDetails = m.PatientDetails.ToList();
            return View(PatientDetails);
        }
        [HttpGet]
        public IActionResult Update(string id) 
        {
            var st = m.PatientDetails.Find(id);
            return View(st);
        }
        [HttpPost]
        public IActionResult Update(Patient_entry a)
        {
            if(! ModelState.IsValid)
            {
                TempData["a"] = "modelstate is not valid";
                return View();
            }
            try
            {
                m.PatientDetails.Update(a);
                m.SaveChanges();
                TempData["a"] = "Value added succesfully";
                return RedirectToAction("Read");
            }
            catch(Exception ex)
            {
                return View(ex.Message);
            }
        }
        public IActionResult Delete(string id)
        {
            var st = m.PatientDetails.Find(id);
            m.PatientDetails.Remove(st);
            m.SaveChanges();
            return RedirectToAction("Read");
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}

