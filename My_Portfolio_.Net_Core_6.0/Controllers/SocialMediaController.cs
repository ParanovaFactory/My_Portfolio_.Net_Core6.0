using Microsoft.AspNetCore.Mvc;
using My_Portfolio_.Net_Core_6._0.DAL.Concrete;
using My_Portfolio_.Net_Core_6._0.DAL.Entities;

namespace My_Portfolio_.Net_Core_6._0.Controllers
{
    public class SocialMediaController : Controller
    {
        Context context = new Context();

        public IActionResult SocialMediaList()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(SocialMedia p)
        {
            context.SocialMedias.Add(p);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        public IActionResult Delete(int id)
        {
            var value = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Edit(SocialMedia p)
        {
            var value = context.SocialMedias.Find(p.SocialMediaId);
            context.SocialMedias.Update(value);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}
