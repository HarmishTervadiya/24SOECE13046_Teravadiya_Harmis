using Microsoft.AspNetCore.Mvc;
using NetCoreWebApp_Example.Models;

namespace NetCoreWebApp_Example.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            AccountModel obj = new AccountModel();
            return View(obj.getData());
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(AccountModel model)
        {
            if (model.Insert())
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            AccountModel obj = new AccountModel();
            var model = obj.GetByAccountNo(id);
            if (model == null) return RedirectToAction("Index");
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(AccountModel model)
        {
            if (model.Update())
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Discard(int id)
        {
            AccountModel obj = new AccountModel();
            obj.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
