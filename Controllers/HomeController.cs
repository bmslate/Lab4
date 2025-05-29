using Microsoft.AspNetCore.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Welcome with ViewBag";
            ViewData["Title"] = "Welcome with ViewData";
            
            return View();
        }

        public IActionResult SongForm() => View();
        [HttpPost]
        public IActionResult Sing(int monkeyCount)
        {
            ViewData["Title"] = "Sing";
            if (monkeyCount < 20 || monkeyCount > 30)
            {
                return RedirectToAction("SongForm");
            }

            ViewBag.MonkeyCount = monkeyCount;
            return View();
        }
        //public IActionResult Sing()
        //{
        //    ViewData["Title"] = "Sing";
        //    // you will complete this
        //    return View();
        //}
        public IActionResult CreateStudent() => View();
        [HttpPost]
        public IActionResult DisplayStudent(Student student)
        {
            // you will complete this
            return View(student);
        }
        public IActionResult Error()
        {
            ViewData["Error"] = "Error message";
            return View();
        }
    }
}
