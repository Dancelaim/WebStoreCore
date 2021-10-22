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
    public class HtmlBlockController : ControllerBase
    {
        private readonly ILogger<HtmlBlockController> _logger;
        private readonly ApplicationContext _context;
        private IMapper _mapper;

        public HtmlBlockController(ILogger<HtmlBlockController> logger, ApplicationContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("getHtmlBlocks")]
        public async Task<IActionResult> GetHtmlBlocks(HtmlBlockRequest request)
        {
            var result = new HtmlBlockResponse();

            var htmlBlock = await _context.HtmlBlocks.Skip(request.Skip).Take(request.Quantity).Select(p => new HtmlBlock { SiteBlockId = p.SiteBlockId, ParentTitle = p.ParentTitle }).ToListAsync();
            if (htmlBlock.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.HtmlBlocks = htmlBlock;
            return Ok(result);
        }
        [HttpPost("getSearchMethodForHtmlBlocks")]
        public async Task<IActionResult> getSearchMethodForHtmlBlocks(HtmlBlockRequest request,string Name)
        {
            var result = new HtmlBlockResponse();

            var htmlBlock = await _context.HtmlBlocks.Take(request.Quantity).Where(c => c.ParentTitle.StartsWith(Name) || c.ParentTitle.Contains(Name) || c.ParentTitle.EndsWith(Name)).Select(p => new HtmlBlock { SiteBlockId = p.SiteBlockId, ParentTitle = p.ParentTitle }).ToListAsync();
            if (htmlBlock.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.HtmlBlocks = htmlBlock;
            return Ok(result);
        }
    }
}
