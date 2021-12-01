using Admin.ApiModels.Request;
using Admin.ApiModels.Response;
using Admin.Core;
using Admin.Models;
using AutoMapper;
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
    [Route("admin/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ApplicationContext _context;
        private IMapper _mapper;

        public ProductController(ILogger<ProductController> logger, ApplicationContext context, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
            _context = context;
        }
        [HttpGet("test")]
        public string Test()
        {
            return "OCELOT test successfull";
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
        
        [HttpGet("getProduct")]
        public async Task<IActionResult> GetProduct(Guid ProductId)
        {
            var response = new ProductResponse();
            var result = await _context.Product.Where(p => p.ProductId == ProductId).Select(p => new {p,  p.ProductCategory, p.ProductSeo,p.ProductGame, p.ProductPrices}).FirstOrDefaultAsync();
            if (result == null)
            {
                response.Code = -100;
                response.Message = "Can't get products with given parameters.";
                return Ok(response);
            }
            
            response.Product = _mapper.Map<Product>(result.p);
            response.Product = _mapper.Map(result.ProductPrices, response.Product);
            response.Product = _mapper.Map(result.ProductGame, response.Product);
            response.Product = _mapper.Map(result.ProductCategory, response.Product);
            response.Product = _mapper.Map(result.ProductSeo, response.Product);

            response.Code = 100;
            response.Message = "Success";
            return Ok(response);
        }
        
        [HttpPost("getDescriptionByProduct")]
        public async Task<IActionResult> GetDescriptionByProduct(Guid ProductId)
        {
            var description = await _context.Product.Where(p => p.ProductId == ProductId).Select(p => p.ProductDescription).FirstOrDefaultAsync();
            var result = _mapper.Map<DescriptionResponse>(description);
            result.Code = 100;
            result.Message = "Success";
            return Ok(result);
        }
        [HttpPost("getSearchMethodForProduct")]
        public async Task<IActionResult> GetSearchMethodForProduct(string Name , int Quantity)
        {
            var result = new ProductsResponse();

            var products = await _context.Product.Take(Quantity).Where(c => c.ProductName.StartsWith(Name) || c.ProductName.Contains(Name) || c.ProductName.EndsWith(Name)).Select(p => new Product { ProductId = p.ProductId, ProductName = p.ProductName }).ToListAsync();
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
        [HttpPut("updateProduct")]
        public async Task<IActionResult> UpdateProduct(ProductUpdateRequest request)
        {
            var response = new ProductUpdateResponse();

            var DBProduct = await _context.Product.Where(p=> p.ProductId == request.Product.ProductId).FirstOrDefaultAsync();
            var DBPrice = await _context.ProductPrice.Where(p => p.ProductId == request.Product.ProductId).FirstOrDefaultAsync();
            var DBDescription = await _context.ProductDescription.Where(d => d.ProductDescriptionId == DBProduct.ProductDescriptionId).FirstOrDefaultAsync();
      
            DBProduct = _mapper.Map(request.Product, DBProduct);
            DBPrice = _mapper.Map(request.Price, DBPrice);
            DBDescription = _mapper.Map(request.Description, DBDescription);

            _context.Product.Update(DBProduct);
            _context.ProductPrice.Update(DBPrice);
            _context.ProductDescription.Update(DBDescription);

            await _context.SaveChangesAsync();

            response.Code = 100;
            response.Message = "Product Update Success";
            return Ok(response);
            
        }


    }
}
