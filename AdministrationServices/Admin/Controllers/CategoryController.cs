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
    [Route("admin/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ApplicationContext _context;
        private IMapper _mapper;

        public CategoryController(ILogger<CategoryController> logger, ApplicationContext context, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
            _context = context;
        }

        [HttpPost("getProductCategory")]
        public async Task<IActionResult> GetProductCategory(ProductCategoryRequest request)
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
