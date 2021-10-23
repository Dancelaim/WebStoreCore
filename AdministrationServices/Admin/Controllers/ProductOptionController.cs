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
    public class ProductOptionController : ControllerBase
    {
        private readonly ILogger<ProductOptionController> _logger;
        private readonly ApplicationContext _context;
        private IMapper _mapper;

        public ProductOptionController(ILogger<ProductOptionController> logger, ApplicationContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("getProductOption")]
        public async Task<IActionResult> GetProductOption(ProductOptionsRequest request)
        {
            var result = new ProductOptionsResponse();

            var productOptions = await _context.ProductOptions.Skip(request.Skip).Take(request.Quantity).Select(p => new ProductOption { OptionId = p.OptionId, OptionName = p.OptionName }).ToListAsync();
            if (productOptions.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.productOptions = productOptions;
            return Ok(result);
        }
        [HttpPost("getSearchMethodForProductOption")]
        public async Task<IActionResult> GetSearchMethodForProductOption(string Name, int Quantity)
        {
            var result = new ProductOptionsResponse();

            var productOptions = await _context.ProductOptions.Take(Quantity).Where(c => c.OptionName.StartsWith(Name) || c.OptionName.Contains(Name) || c.OptionName.EndsWith(Name)).Select(p => new ProductOption { OptionId = p.OptionId, OptionName = p.OptionName }).ToListAsync();
            if (productOptions.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.productOptions = productOptions;
            return Ok(result);
        }
        [HttpGet("getProductOption")]
        public async Task<IActionResult> GetProductOption(Guid OptionId)
        {
            var response = new ProductOptionResponse();

            var productOption = await _context.ProductOptions.Where(p => p.OptionId == OptionId).Select(p => new { p, p.ProductOptionParams}).FirstOrDefaultAsync();
            if (productOption == null)
            {
                response.Code = -100;
                response.Message = "Can't get products with given parameters.";
                return Ok(response);
            }

            response.ProductOption = _mapper.Map<ProductOption>(productOption.p);
            response.ProductOption = _mapper.Map(productOption.ProductOptionParams.First(), response.ProductOption);

            response.Code = 100;
            response.Message = "Success";
            return Ok(response);
        }
    }
}
