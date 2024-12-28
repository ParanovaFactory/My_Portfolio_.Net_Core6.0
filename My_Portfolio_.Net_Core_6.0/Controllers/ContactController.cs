using Microsoft.AspNetCore.Mvc;
using My_Portfolio_.Net_Core_6._0.DAL.Concrete;
using My_Portfolio_.Net_Core_6._0.DAL.Entities;

namespace My_Portfolio_.Net_Core_6._0.Controllers
{
    public class ContactController : Controller
    {
        Context context = new Context();
        public IActionResult ContactList()
        {
            var value = context.Contacts.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Edit(Contact p)
        {
            var value = context.Contacts.Find(p.ContactId);
            context.Contacts.Update(value);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }

        public IActionResult Detail(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }
    }
}
