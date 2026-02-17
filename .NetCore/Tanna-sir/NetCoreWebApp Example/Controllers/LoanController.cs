using Microsoft.AspNetCore.Mvc;
using NetCoreWebApp_Example.Models;

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
            LoanModel obj = new LoanModel();
            List<LoanModel> loans = obj.getData();
            return View(loans);
        }
    }
}
