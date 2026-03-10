using Microsoft.AspNetCore.Mvc;
using NetCoreWebApp_Example.Models;

namespace NetCoreWebApp_Example.Controllers
{
    public class LoanController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("ViewAll");
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(LoanModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Insert())
            {
                TempData["Success"] = "Application submitted successfully.";
                return RedirectToAction("ViewAll");
            }

            ViewBag.Message = "Failed to submit application. Please try again later.";
            return View(model);
        }

        public IActionResult UpdateApplication(int loanNo)
        {
            LoanModel obj = new LoanModel();
            var model = obj.GetByLoanNo(loanNo);
            if (model == null) return RedirectToAction("ViewAll");
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateApplication(LoanModel model)
        {
            if (model.Update())
            {
                ViewBag.Success = "Application updated successfully.";
                return RedirectToAction("ViewAll");
            }
            ViewBag.Message = "Failed to update application.";
            return View(model);
        }

        public IActionResult DiscardApplication(int loanNo)
        {
            LoanModel obj = new LoanModel();
            if (obj.Delete(loanNo))
            {
                return RedirectToAction("ViewAll");
            }
            return RedirectToAction("ViewAll");
        }

        public IActionResult ViewAll()
        {
            LoanModel obj = new LoanModel();
            List<LoanModel> loans = obj.getData();
            return View(loans);
        }
    }
}
