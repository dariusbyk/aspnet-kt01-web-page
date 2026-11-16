using Microsoft.AspNetCore.Mvc;

namespace MvcTasks.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Welcome()
        {
            ViewBag.Message = "Добро пожаловать на сайт!";
            return View();
        }

        public IActionResult Greet(string name)
        {
            ViewBag.Name = name;
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(string message)
        {
            ViewBag.Message = message;
            return View();
        }
    }
}
