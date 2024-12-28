using Microsoft.AspNetCore.Mvc;
using My_Portfolio_.Net_Core_6._0.DAL.Concrete;
using My_Portfolio_.Net_Core_6._0.DAL.Entities;

namespace My_Portfolio_.Net_Core_6._0.Controllers
{
    public class FeatureController : Controller
    {
        Context context = new Context();
        public IActionResult FeatureList()
        {
            var value = context.Features.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value = context.Features.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Edit(Feature p)
        {
            var value = context.Features.Find(p.FeatureId);
            context.Features.Update(value);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }

        public IActionResult Detail(int id)
        {
            var value = context.Features.Find(id);
            return View(value);
        }
    }
}
