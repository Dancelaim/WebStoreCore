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
    public class RecommendedProductsViewComponent : ViewComponent
    {
        private readonly ILogger<RecommendedProductsViewComponent> _logger;
        private WowCarryContext _context;
        public RecommendedProductsViewComponent(ILogger<RecommendedProductsViewComponent> logger, WowCarryContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync(string game)
        {
            var result = await _context.Products.Where(p => p.ProductGame.GameName == game).Include(p => p.ProductPrices).Include(p=>p.ProductSeo).Take(4).ToListAsync();

            return View(result);
        }
    }
}
