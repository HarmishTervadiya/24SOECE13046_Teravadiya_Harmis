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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult New(LoanModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Insert())
            {
                ViewBag.Success = "Application submitted successfully.";
                ModelState.Clear();
                return View();
            }

            ViewBag.Message = "Failed to submit application. Please try again later.";
            return View(model);
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
