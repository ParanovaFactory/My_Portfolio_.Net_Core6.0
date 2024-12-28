using Microsoft.AspNetCore.Mvc;
using My_Portfolio_.Net_Core_6._0.DAL.Concrete;

namespace My_Portfolio_.Net_Core_6._0.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var values = context.Features.ToList();
            return View(values);
        }
    }
}
