using Admin.ApiModels.Request;
using Admin.ApiModels.Response;
using Admin.Core;
using Admin.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
                var response = new ProductsResponse();
                var products = await _context.Product.Skip(request.Skip).Take(request.Quantity).Select(p => new Product { ProductId = p.ProductId, ProductName = p.ProductName }).ToListAsync();
            if (products.Count == 0)
            { return null; }

            response.Products = products;
            return Ok(response);

        }
        [HttpPost("getProduct")]
        public async Task<IActionResult> GetProduct(ProductRequest request)
        {
            var product = await _context.Product.Where(p => p.ProductId == request.ProductId).FirstOrDefaultAsync();
            var price = await _context.ProductPrice.Where(p => p.ProductId == request.ProductId).FirstOrDefaultAsync();
            var result = _mapper.Map<ProductResponse>(product);
                result = _mapper.Map(price, result);
           
            return Ok(result);
        }
        [HttpPost("getDescriptionByProduct")]
        public async Task<IActionResult> GetDescriptionByProduct(ProductRequest request)
        {
            var description = await _context.Product.Where(p => p.ProductId == request.ProductId).Select(p => p.ProductDescription).FirstOrDefaultAsync();

            return Ok(description);
        }
    }
}
