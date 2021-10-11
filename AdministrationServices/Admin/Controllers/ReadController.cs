using Admin.ApiModels;
using Admin.ApiModels.Request;
using Admin.ApiModels.Response;
using Admin.Core;
using Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReadController : ControllerBase
    {
        private readonly ILogger<ReadController> _logger;
        private readonly ApplicationContext _context;

        public ReadController(ILogger<ReadController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }
        /// <summary>
        ///  Получаем список продуктов 
        /// </summary>
        /// <param name="request"></param>
        [HttpPost]
        public async Task<ActionResult> GetProduct(ProductRequest request)
        {
            
                var response = new ProductResponse();
                var products = await _context.Product.Skip(request.Skip).Take(request.Quantity).Select(p => new Product { ProductId = p.ProductId, ProductName = p.ProductName }).ToListAsync();
            if ( products.Count == 0) 
                return null;

            response.Products = products;
            return Ok(response);

        }
    }
}
