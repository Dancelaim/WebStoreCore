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
    public class ProductSubCategoryController : ControllerBase
    {
        private readonly ILogger<ProductSubCategoryController> _logger;
        private readonly WowCarryContext _context;
        private IMapper _mapper;

        public ProductSubCategoryController(ILogger<ProductSubCategoryController> logger, WowCarryContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("getProductSubCategory")]
        public async Task<IActionResult> GetProductSubCategory(ProductSubCategoryRequest request)
        {
            var result = new ProductSubCategoryResponse();

            var ProductSubCategory = await _context.ProductSubCategory.Skip(request.Skip).Take(request.Quantity).Select(p => new ProductSubCategory { ProductSubCategoryId = p.Id, ProductCategoryName = p.Name }).ToListAsync();
            if (ProductSubCategory.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.productSubCategories = ProductSubCategory;
            return Ok(result);
        }
        [HttpPost("getSearchMethodForSubCategory")]
        public async Task<IActionResult> GetSearchMethodForSubCategory(ProductSubCategoryRequest request, string Name)
        {
            var result = new ProductSubCategoryResponse();

            var ProductSubCategory = await _context.ProductSubCategory.Take(request.Quantity).Where(c => c.Name.StartsWith(Name) || c.Name.Contains(Name) || c.Name.EndsWith(Name)).Select(p => new ProductSubCategory { ProductSubCategoryId = p.Id, ProductCategoryName = p.Name }).ToListAsync();
            if (ProductSubCategory.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.productSubCategories = ProductSubCategory;
            return Ok(result);
        }
    }
}
