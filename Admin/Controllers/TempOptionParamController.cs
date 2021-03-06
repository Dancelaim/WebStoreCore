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
    public class TempOptionParamController : ControllerBase
    {
        private readonly ILogger<TempOptionParamController> _logger;
        private readonly WowCarryContext _context;
        private IMapper _mapper;

        public TempOptionParamController(ILogger<TempOptionParamController> logger, WowCarryContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("getTempOptionParams")]
        public async Task<IActionResult> GetTempOptionParams(TempOptionParamsRequest request)
        {
            var result = new TempOptionParamsResponse();

            var tempOptionParams = await _context.TempOptionParams.Skip(request.Skip).Take(request.Quantity).Select(p => new TempOptionParam { ParameterId = p.Id, ParameterName = p.Name }).ToListAsync();
            if (tempOptionParams.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.tempOptionParams = tempOptionParams;
            return Ok(result);
        }
        [HttpPost("getSearchMethodForTempOptionParams")]
        public async Task<IActionResult> GetSearchMethodForTempOptionParams(string Name, int Quantity)
        {
            var result = new TempOptionParamsResponse();

            var tempOptionParams = await _context.TempOptionParams.Take(Quantity).Where(c => c.Name.StartsWith(Name) || c.Name.Contains(Name) || c.Name.EndsWith(Name)).Select(p => new TempOptionParam { ParameterId = p.Id, ParameterName = p.Name }).ToListAsync();
            if (tempOptionParams.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.tempOptionParams = tempOptionParams;
            return Ok(result);
        }
        [HttpGet("getTempOptionParam")]
        public async Task<IActionResult> GetTempOptionParam(Guid ParamId)
        {
            var response = new TempOptionParamResponse();

            var tempOptionParams = await _context.TempOptionParams.Where(p => p.Id == ParamId).Select(p => new TempOptionParam {ParameterName = p.Name , ParameterPrice = p.ParameterPrice, ParameterSale = p.ParameterSale , Delete = p.Delete, ParameterTooltip = p.ParameterTooltip , ParentOptionId = p.ParentOptionId}).FirstOrDefaultAsync();
            if (tempOptionParams == null)
            {
                response.Code = -100;
                response.Message = "Can't get products with given parameters.";
                return Ok(response);
            }

            response.Code = 100;
            response.Message = "Success";
            response.TempOptionParam = tempOptionParams;
            return Ok(response);
        }
    }
}
