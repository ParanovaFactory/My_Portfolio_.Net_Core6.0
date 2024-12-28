using Microsoft.AspNetCore.Mvc;
using My_Portfolio_.Net_Core_6._0.DAL.Concrete;
using My_Portfolio_.Net_Core_6._0.DAL.Entities;

namespace My_Portfolio_.Net_Core_6._0.Controllers
{
    public class MessageController : Controller
    {
        Context context = new Context();

        public IActionResult MessageList()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        public IActionResult Edit(Message p)
        {
            var value = context.Messages.Find(p.MessageId);
            p.MessageIsRead = true;
            context.Messages.Update(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult Detail(int id)
        {
            var value = context.Messages.Find(id);
            return View(value);
        }
    }
}
