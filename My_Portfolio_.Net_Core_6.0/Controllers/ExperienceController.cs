using Microsoft.AspNetCore.Mvc;
using My_Portfolio_.Net_Core_6._0.DAL.Concrete;
using My_Portfolio_.Net_Core_6._0.DAL.Entities;

namespace My_Portfolio_.Net_Core_6._0.Controllers
{
    public class ExperienceController : Controller
    {
        Context context = new Context();

        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Experience p)
        {
            context.Experiences.Add(p);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult Delete(int id)
        {
            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value = context.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Edit(Experience p)
        {
            var value = context.Experiences.Find(p.ExperienceId);
            context.Experiences.Update(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult Detail(int id)
        {
            var value = context.Experiences.Find(id);
            return View(value);
        }
    }
}
