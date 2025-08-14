using Microsoft.AspNetCore.Mvc;

namespace First_MVC_project.Controllers
{
    public class SportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult First()
        {
            return View();
        }

        public IActionResult Second()
        {
            return View();
        }

        public IActionResult Third()
        {
            return View();
        }
    }
}
