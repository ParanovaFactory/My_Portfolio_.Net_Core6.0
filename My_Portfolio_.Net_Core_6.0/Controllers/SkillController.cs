using Microsoft.AspNetCore.Mvc;
using My_Portfolio_.Net_Core_6._0.DAL.Concrete;
using My_Portfolio_.Net_Core_6._0.DAL.Entities;

namespace My_Portfolio_.Net_Core_6._0.Controllers
{
    public class SkillController : Controller
    {
        Context context = new Context();

        public IActionResult SkillList()
        {
            var values = context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Skill p)
        {
            context.Skills.Add(p);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public IActionResult Delete(int id)
        {
            var value = context.Skills.Find(id);
            context.Skills.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value = context.Skills.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Edit(Skill p)
        {
            var value = context.Skills.Find(p.SkillId);
            context.Skills.Update(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}
