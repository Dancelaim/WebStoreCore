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
    public class GameMenuViewComponent : ViewComponent
    {
        private readonly ILogger<GameMenuViewComponent> _logger;
        private WowCarryContext _context;
        public GameMenuViewComponent(ILogger<GameMenuViewComponent> logger, WowCarryContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var games = await GetItemsAsync();

            return View(games);
        }
        private Task<List<string>> GetItemsAsync()
        {
            return _context.Products.Select(p => p.ProductGame).Select(g => g.GameName).Distinct().ToListAsync();
        }
    }
}

