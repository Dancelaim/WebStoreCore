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
    public class GameCategoryMenuViewComponent : ViewComponent
    {
        private readonly ILogger<GameCategoryMenuViewComponent> _logger;
        private WowCarryContext _context;
        public GameCategoryMenuViewComponent(ILogger<GameCategoryMenuViewComponent> logger, WowCarryContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories =  await _context.ProductCategories
                .Select(c => new { c.ProductGame.GameName, c.ProductCategoryName }).OrderBy(k => k.GameName).ToListAsync();

            var result = categories.Select(c => new KeyValuePair<string, string>(c.GameName, c.ProductCategoryName)).GroupBy(c=>c.Key);
            return View(result);
        }
    }
}
