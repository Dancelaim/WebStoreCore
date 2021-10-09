using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WowCarryCore.Models;

namespace WowCarryCore
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly ILogger<BlogViewComponent> _logger;
        private WowCarryContext _context;
        public BlogViewComponent(ILogger<BlogViewComponent> logger, WowCarryContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var BlogsPreview = await _context.Articles.OrderBy(a => a.ArticlePostTime).Take(4).ToListAsync();

            return View(BlogsPreview);
        }
    }
}

