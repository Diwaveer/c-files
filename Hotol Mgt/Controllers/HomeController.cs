using Hotol_Mgt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hotol_Mgt.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext m;

        public HomeController(DatabaseContext a)
        {
            m = a;

        }

        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(College a)
        {

            if (!ModelState.IsValid)
            {
                TempData["a"] = "Modelstate is not valid";
            }
            try
            {
                m.StudentDetails.Add(a);
                m.SaveChanges();
                TempData["a"] = "Values Added Succesfully";
                return RedirectToAction("Add");
            }
            catch (Exception ex)
            {
                TempData["a"] = ex.Message;


                return View();
            }
        }
        public IActionResult Read()
        {
            var StudentDetails = m.StudentDetails.ToList();
            return View(StudentDetails);
        }

        public IActionResult Edit(int id)
        {
            var st = m.StudentDetails.Find(id);
            return View(st);
        }
        [HttpPost]
        public IActionResult Edit(College st)
        {
            if (!ModelState.IsValid)
            {
                TempData["a"] = "Model state is not valid";
                return View();
            }
            try
            {
                m.StudentDetails.Update(st);
                m.SaveChanges();
                TempData["a"] = "Updated succesfully";
                return RedirectToAction("Read");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
        public IActionResult Delete(int id)
        {
            var del = m.StudentDetails.Find(id);
            m.StudentDetails.Remove(del);
            m.SaveChanges();
            return RedirectToAction("Read");
        }

    }
}
