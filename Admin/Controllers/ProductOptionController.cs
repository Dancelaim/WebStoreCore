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
        private readonly WowCarryContext _context;
        private IMapper _mapper;

        public ProductOptionController(ILogger<ProductOptionController> logger, WowCarryContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("getProductOptions")]
        public async Task<IActionResult> GetProductOptions(ProductOptionsRequest request)
        {
            var result = new ProductOptionsResponse();

            var productOptions = await _context.ProductOptions.Where(c=> c.OptionProductId == request.ProductId).Select(p => new ProductOption { OptionId = p.Id, OptionName = p.Name }).ToListAsync();
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

            var productOption = await _context.ProductOptions.Where(p => p.Id == OptionId).Select(p => new ProductOption { OptionName = p.Name, OptionParentId = p.OptionParentId }).FirstOrDefaultAsync();
            if (productOption == null)
            {
                response.Code = -100;
                response.Message = "Can't get products with given parameters.";
                return Ok(response);
            }
           

            response.Code = 100;
            response.Message = "Success";
            response.ProductOption = productOption;
            return Ok(response);
        }
        [HttpPost("getProductOptionParams")]
        public async Task<IActionResult> GetProductOptionParams(Guid OptionId)
        {
            var response = new ProductOptionParamsResponse();

            var productOptionParams = await _context.ProductOptionParams.Where(p => p.ParentOptionId == OptionId).Select(p => new ProductOptionParam {ParameterId = p.Id,ParameterName = p.Name, ParameterTooltip = p.ParameterTooltip, ParameterPrice = p.ParameterPrice,ParameterSale = p.ParameterSale,ParameterParentId = p.ParameterParentId }).ToListAsync();
            if (productOptionParams == null)
            {
                response.Code = -100;
                response.Message = "Can't get products with given parameters.";
                return Ok(response);
            }

            response.Code = 100;
            response.Message = "Success";
            response.productOptionParams = productOptionParams;
            return Ok(response);
        }
    }
}
