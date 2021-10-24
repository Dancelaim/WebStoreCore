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
    public class TemplateOptionController : ControllerBase
    {
        private readonly ILogger<TemplateOptionController> _logger;
        private readonly ApplicationContext _context;
        private IMapper _mapper;

        public TemplateOptionController(ILogger<TemplateOptionController> logger, ApplicationContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("getTemplateOptions")]
        public async Task<IActionResult> GetTemplateOptions(TemplateOptionsRequest request)
        {
            var result = new TemplateOptionsResponse();

            var templateOption = await _context.TemplateOptions.Skip(request.Skip).Take(request.Quantity).Select(p => new TemplateOption { OptionId = p.OptionId, OptionName = p.OptionName }).ToListAsync();
            if (templateOption.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.templateOptions = templateOption;
            return Ok(result);
        }
        [HttpPost("getSearchMethodForTemplateOptions")]
        public async Task<IActionResult> GetSearchMethodForTemplateOptions(string Name, int Quantity)
        {
            var result = new TemplateOptionsResponse();

            var templateOption = await _context.TemplateOptions.Take(Quantity).Where(c => c.OptionName.StartsWith(Name) || c.OptionName.Contains(Name) || c.OptionName.EndsWith(Name)).Select(p => new TemplateOption { OptionId = p.OptionId, OptionName = p.OptionName }).ToListAsync();

            if (templateOption.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.templateOptions = templateOption;
            return Ok(result);
        }
        [HttpGet("getDependencyTemplateOption")]
        public async Task<IActionResult> getDependencyTemplateOption(Guid TempOptionId)
        {
            var response = new TemplateOptionResponse();

            var templateOption = await _context.TemplateOptions.Where(p => p.OptionId == TempOptionId).Select(p => new TemplateOption { OptionName = p.OptionName, OptionParentId = p.OptionParentId }).FirstOrDefaultAsync();
            if (templateOption == null)
            {
                response.Code = -100;
                response.Message = "Can't get products with given parameters.";
                return Ok(response);
            }


            response.Code = 100;
            response.Message = "Success";
            response.templateOption = templateOption;
            return Ok(response);
        }
        [HttpGet("getTemplateOption")]
        public async Task<IActionResult> GetTemplateOption(Guid TempOptionId)
        {
            var response = new TemplateOptionResponse();

            var templateOption = await _context.TemplateOptions.Where(p => p.OptionId == TempOptionId).Select(p => new { p, p.TempOptionParams }).FirstOrDefaultAsync();
            if (templateOption == null)
            {
                response.Code = -100;
                response.Message = "Can't get products with given parameters.";
                return Ok(response);
            }

            response.templateOption = _mapper.Map<TemplateOption>(templateOption.p);
            response.templateOption = _mapper.Map(templateOption.TempOptionParams.First(), response.templateOption);

            response.Code = 100;
            response.Message = "Success";
            return Ok(response);
        }
    }
}
