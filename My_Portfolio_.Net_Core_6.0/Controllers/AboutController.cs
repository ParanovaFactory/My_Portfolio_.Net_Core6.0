using Microsoft.AspNetCore.Mvc;
using My_Portfolio_.Net_Core_6._0.DAL.Concrete;
using My_Portfolio_.Net_Core_6._0.DAL.Entities;

namespace My_Portfolio_.Net_Core_6._0.Controllers
{
    public class AboutController : Controller
    {
        Context context = new Context();

        public IActionResult AboutList()
        {
            var value = context.Abouts.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Edit(About p)
        {
            var value = context.Abouts.Find(p.AboutId);
            context.Abouts.Update(value);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public IActionResult Detail(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }
    }
}
