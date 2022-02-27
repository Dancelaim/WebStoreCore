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
    public class ProductOptionParamController : ControllerBase
    {
        private readonly ILogger<ProductOptionParamController> _logger;
        private readonly WowCarryContext _context;
        private IMapper _mapper;

        public ProductOptionParamController(ILogger<ProductOptionParamController> logger, WowCarryContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("getOptionParams")]
        public async Task<IActionResult> GetOptionParams(ProductOptionParamRequest request)
        {
            var result = new ProductOptionParamsResponse();

            var OptionParams = await _context.ProductOptionParams.Skip(request.Skip).Take(request.Quantity).Select(p => new ProductOptionParam { ParameterId = p.Id, ParameterName = p.ParameterName }).ToListAsync();
            if (OptionParams.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.productOptionParams = OptionParams;
            return Ok(result);
        }
        [HttpPost("getSearchMethodForOptionParams")]
        public async Task<IActionResult> GetSearchMethodForOptionParams(string Name, int Quantity)
        {
            var result = new ProductOptionParamsResponse();

            var OptionParams = await _context.ProductOptionParams.Take(Quantity).Where(c => c.ParameterName.StartsWith(Name) || c.ParameterName.Contains(Name) || c.ParameterName.EndsWith(Name)).Select(p => new ProductOptionParam { ParameterId = p.Id, ParameterName = p.ParameterName }).ToListAsync();
            if (OptionParams.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.productOptionParams = OptionParams;
            return Ok(result);
        }
        [HttpGet("getOptionParam")]
        public async Task<IActionResult> GetOptionParam(Guid ParamId)
        {
            var response = new ProductOptionParamResponse();

            var OptionParam = await _context.ProductOptionParams.Where(p => p.Id == ParamId).Select(p => new ProductOptionParam { ParameterName = p.ParameterName, ParameterPrice = p.ParameterPrice, ParameterSale = p.ParameterSale, ParameterTooltip = p.ParameterTooltip, ParentOptionId = p.ParentOptionId, ParameterParentId = p.ParameterParentId }).FirstOrDefaultAsync();
            if (OptionParam == null)
            {
                response.Code = -100;
                response.Message = "Can't get products with given parameters.";
                return Ok(response);
            }

            response.Code = 100;
            response.Message = "Success";
            response.ProductOptionParam = OptionParam;
            return Ok(response);
        }
    }
}
