using Microsoft.AspNetCore.Mvc;
using My_Portfolio_.Net_Core_6._0.DAL.Concrete;
using My_Portfolio_.Net_Core_6._0.DAL.Entities;

namespace My_Portfolio_.Net_Core_6._0.Controllers
{
    public class PortfolioController : Controller
    {
        Context context = new Context();

        public IActionResult PortfolioList()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Portfolio p)
        {
            context.Portfolios.Add(p);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult Delete(int id)
        {
            var value = context.Portfolios.Find(id);
            context.Portfolios.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value = context.Portfolios.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Edit(Portfolio p)
        {
            var value = context.Portfolios.Find(p.PortfolioId);
            context.Portfolios.Update(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult Detail(int id)
        {
            var value = context.Portfolios.Find(id);
            return View(value);
        }
    }
}
