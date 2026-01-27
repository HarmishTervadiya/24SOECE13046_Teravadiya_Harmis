using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApp_Example.Controllers
{
    public class LoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {
            return View();
        }

        public IActionResult UpdateApplication()
        {
            return View();
        }

        public IActionResult DiscardApplication()
        {
            return View();
        }

        public IActionResult ViewAll()
        {
            return View();
        }
    }
}
