using Microsoft.AspNetCore.Mvc;
using NetCoreWebApp_Example.Models;

namespace NetCoreWebApp_Example.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            UserModel obj = new UserModel();
            return View(obj.getData());
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(UserModel model)
        {
            if (model.Insert())
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(string id)
        {
            UserModel obj = new UserModel();
            var model = obj.GetByEmail(id);
            if (model == null) return RedirectToAction("Index");
            ViewBag.OldEmail = id;
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(UserModel model, string oldEmail)
        {
            if (model.Update(oldEmail))
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Discard(string id)
        {
            UserModel obj = new UserModel();
            obj.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
