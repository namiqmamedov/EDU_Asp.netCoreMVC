﻿using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class AboutNoticeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(IEnumerable<AboutNotice> aboutNotices)
        {
            return View(await Task.FromResult(aboutNotices));
        }
    }
}
