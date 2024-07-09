using Hospital_Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management.Controllers
{
    public class BillentryController : Controller
    {
        private readonly DatabaseContext o;
        public BillentryController(DatabaseContext c)
        {
            o = c;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Bill_entry c)
        {
            if (!ModelState.IsValid)
            {
                TempData["a"] = "Modelstate is not valid";
            }
            try
            {
                o.BillDetails.Add(c);
                o.SaveChanges();
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
            var billDetails = o.BillDetails.ToList();
            return View(billDetails);
        }
        [HttpGet]
        public IActionResult Update(string id)
        {
            var st = o.BillDetails.Find(id);
            return View(st);
        }
        [HttpPost]
        public IActionResult Update(Bill_entry c)
        {
            if (!ModelState.IsValid)
            {
                TempData["a"] = "modelstate is not valid";
                return View();
            }
            try
            {
                o.BillDetails.Update(c);
                o.SaveChanges();
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
            var st = o.BillDetails.Find(id);
            o.BillDetails.Remove(st);
            o.SaveChanges();
            return RedirectToAction("Read");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
