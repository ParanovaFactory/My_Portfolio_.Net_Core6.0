﻿using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio_.Net_Core_6._0.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}