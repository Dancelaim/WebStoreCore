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
    public class HtmlBlocksChildController : ControllerBase
    {
        private readonly ILogger<HtmlBlocksChildController> _logger;
        private readonly ApplicationContext _context;
        private IMapper _mapper;

        public HtmlBlocksChildController(ILogger<HtmlBlocksChildController> logger, ApplicationContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("getHtmlBlocksChild")]
        public async Task<IActionResult> GetHtmlBlocksChild(HtmlBlocksChildRequest request)
        {
            var result = new HtmlBlocksChildResponse();

            var htmlBlockChild = await _context.HtmlBlocksChildren.Skip(request.Skip).Take(request.Quantity).Select(p => new HtmlBlocksChild { SiteBlockChildsId = p.SiteBlockChildsId, Title = p.Title }).ToListAsync();
            if (htmlBlockChild.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.htmlBlocksChildren = htmlBlockChild;
            return Ok(result);
        }
        [HttpPost("getSearchMethodForBlocksChild")]
        public async Task<IActionResult> GetSearchMethodForBlocksChild(HtmlBlocksChildRequest request, string Name)
        {
            var result = new HtmlBlocksChildResponse();

            var htmlBlockChild = await _context.HtmlBlocksChildren.Take(request.Quantity).Where(c => c.Title.StartsWith(Name) || c.Title.Contains(Name) || c.Title.EndsWith(Name)).Select(p => new HtmlBlocksChild { SiteBlockChildsId = p.SiteBlockChildsId, Title = p.Title }).ToListAsync();
            if (htmlBlockChild.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.htmlBlocksChildren = htmlBlockChild;
            return Ok(result);
        }
    }
}
