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
    public class SiteBlockViewComponent : ViewComponent
    {
        private readonly ILogger<SiteBlockViewComponent> _logger;
        private WowCarryContext _context;
        public SiteBlockViewComponent(ILogger<SiteBlockViewComponent> logger, WowCarryContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync(string requestedPage)
        {
            var siteBlocks = await _context.HtmlBlocks.Where(b => b.SitePage == requestedPage).Include(x => x.HtmlBlocksChildren).OrderBy(s => s.Order).ToListAsync();

            return View(siteBlocks);
        }
    }
}
