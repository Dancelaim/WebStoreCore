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
            var productAndPrice = await _context.Product.Where(p => p.ProductId == request.ProductId).Select(p => new {p, p.ProductPrices}).FirstOrDefaultAsync();
            var result = _mapper.Map<ProductResponse>(productAndPrice.p);
            //Todo: Fix pricec foreign keys.
                result = _mapper.Map(productAndPrice.ProductPrices.First(), result);

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
        [HttpPost("getDescriptionByProduct")]
        //добавить коллекции геймс, СЕОс,категории
        //геймы все для продукта и админки
        //Категории функция либо все либо отфильтрованнные по игре(where)
        //Сео все
    }
}
