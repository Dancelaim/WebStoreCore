using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Admin.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Core;
using Admin.ApiModels;

namespace Admin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private ApplicationContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger , ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public WeatherForecast Get()
        {
            var testArticle = _context.Article.ToList();
            var testProduct = _context.Product.ToList();
            var testCustomer = _context.Customers.ToList();
            var testHtmlBlock = _context.HtmlBlocks.ToList();
            var testHtmlBlockChild = _context.HtmlBlocksChildren.ToList();
            var testOrder = _context.Orders.ToList();
            var testOrderCustomField = _context.OrderCustomFields.ToList();
            var testOrderProduct = _context.OrderProduct.ToList();
            var testProductCategory = _context.ProductCategory.ToList();
            var testProductOption = _context.ProductOptions.ToList();
            var testProductOptionParam = _context.ProductOptionParams.ToList();
            var testProductPrice = _context.ProductPrice.ToList();
            var testProductSubCategory = _context.ProductSubCategory.ToList();
            var testRank = _context.Ranks.ToList();
            var testRealm = _context.Realms.ToList();
            var testRole = _context.Roles.ToList();
            var testSeo = _context.Seo.ToList();
            var testTemplateOption = _context.TemplateOptions.ToList();
            var testTempOptionParam = _context.TempOptionParams.ToList();
            var testUser = _context.Users.ToList();

            var rng = new Random();
            //_context.weatherForecasts.OrderBy(c => Guid.NewGuid()).FirstOrDefault();
            
            return new WeatherForecast
            {
                Date = DateTime.Now.AddDays(rng.Next(1,30)),
                TemperatureC = rng.Next(-20, 55),
                //Weather = _context.Weathers.ToList().ElementAt(rng.Next(0,6)).Weather
            };
        }
    }
}
