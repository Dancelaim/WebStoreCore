using Admin.ApiModels.Request;
using Admin.ApiModels.Response;
using Admin.Core;
using Admin.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetController : ControllerBase
    {
        private readonly ILogger<GetController> _logger;
        private readonly ApplicationContext _context;
        private IMapper _mapper;

        public GetController(ILogger<GetController> logger, ApplicationContext context, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
            _context = context;
        }

        [HttpPost("getProducts")]
        public async Task<IActionResult> GetProducts(ProductsRequest request)
        {
            var result = new ProductsResponse();

            var products = await _context.Product.Skip(request.Skip).Take(request.Quantity).Select(p => new Product { ProductId = p.ProductId, ProductName = p.ProductName }).ToListAsync();
            if (products.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.Products = products;
            return Ok(result);
        }
        
        [HttpPost("getProduct")]
        public async Task<IActionResult> GetProduct(ProductRequest request)
        {
            var productAndPrice = await _context.Product.Where(p => p.ProductId == request.ProductId).Select(p => new {p, p.ProductPrices, p.ProductCategory, p.ProductSeo,p.ProductGame}).FirstOrDefaultAsync();
            var result = _mapper.Map<ProductResponse>(productAndPrice.p);
            //Todo: Fix pricec foreign keys.
                result = _mapper.Map(productAndPrice.ProductPrices.First(), result);
                result = _mapper.Map(productAndPrice.ProductGame, result);
                result = _mapper.Map(productAndPrice.ProductCategory, result);
                result = _mapper.Map(productAndPrice.ProductSeo, result);

            result.Code = 100;
            result.Message = "Success";
            return Ok(result);
        }
        
        [HttpPost("getDescriptionByProduct")]
        public async Task<IActionResult> GetDescriptionByProduct(ProductRequest request)
        {
            var description = await _context.Product.Where(p => p.ProductId == request.ProductId).Select(p => p.ProductDescription).FirstOrDefaultAsync();
            var result = _mapper.Map<DescriptionResponse>(description);
            result.Code = 100;
            result.Message = "Success";
            return Ok(result);
        }

        [HttpPost("getProductGame")]
        public async Task<IActionResult> GetProductGame(ProductGameRequest request)
        {
            var result = new ProductGameResponse();

            var games = await _context.ProductGame.Select(p => new ProductGame { ProductGameId = p.ProductGameId, ProductGameName = p.GameName }).ToListAsync();
            if (games.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.ProductGames = games;
            return Ok(result);
        }

        [HttpPost("getSeo")]
        public async Task<IActionResult> GetSeo(SeoRequest request)
        {
            var result = new SeoResponse();

            var seo = await _context.Seo.Skip(request.Skip).Take(request.Quantity).Select(s => new Seo { SeoId = s.SeoId, MetaTagTitle = s.MetaTagTitle }).ToListAsync();
            if (seo.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.Seo = seo;
            return Ok(result);
        }

        [HttpPost("getProductCategory")]
        public async Task<IActionResult> GetProductCategory (ProductCategoryRequest request)
        {
            var result = new ProductCategoryResponse();

                var productCategory = await _context.ProductCategory.Where(p => request.ProductGameId == null || p.ProductGameId == request.ProductGameId).Select(pc => new ProductCategory { ProductCategoryId = pc.ProductCategoryId, ProductCategoryName = pc.ProductCategoryName }).ToListAsync();
                if (productCategory.Count == 0)
                {
                    result.Code = -100;
                    result.Message = "Can't get products with given parameters.";
                    return Ok(result);
                }
                result.Code = 100;
                result.Message = "Success";
                result.ProductCategory = productCategory;
                return Ok(result);
        }
    }
}
