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
    public class CategoryMenuViewComponent : ViewComponent
    {
        private readonly ILogger<CategoryMenuViewComponent> _logger;
        private WowCarryContext _context;
        public CategoryMenuViewComponent(ILogger<CategoryMenuViewComponent> logger, WowCarryContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string currentGame = HttpContext.Session.GetString("SelectedGame");

            var categories = await GetItemsAsync(currentGame);

            return View(categories);
        }
        private Task<List<string>> GetItemsAsync(string currentGame)
        {
            return _context.Products.Where(p => p.ProductGame.GameName == currentGame).Select(p => p.ProductCategory.ProductCategoryName).Distinct().OrderBy(x => x).ToListAsync();
        }
    }
}

