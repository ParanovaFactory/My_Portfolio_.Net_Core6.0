using Microsoft.AspNetCore.Mvc;
using My_Portfolio_.Net_Core_6._0.DAL.Concrete;
using My_Portfolio_.Net_Core_6._0.DAL.Entities;

namespace My_Portfolio_.Net_Core_6._0.Controllers
{
    public class TestimonialController : Controller
    {
        Context context = new Context();

        public IActionResult TestimonialList()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Testimonial p)
        {
            context.Testimonials.Add(p);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public IActionResult Delete(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Edit(Testimonial p)
        {
            var value = context.Testimonials.Find(p.TestimonialId);
            context.Testimonials.Update(value);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public IActionResult Detail(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }
    }
}
