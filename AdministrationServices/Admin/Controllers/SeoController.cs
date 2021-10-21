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
    public class SeoController : ControllerBase
    {
        private readonly ILogger<SeoController> _logger;
        private readonly ApplicationContext _context;
        private IMapper _mapper;

        public SeoController(ILogger<SeoController> logger, ApplicationContext context, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
            _context = context;
        }

        [HttpPost("getSeo")]
        public async Task<IActionResult> GetSeo(SeoRequest request)
        {
            var result = new SeoResponse();

            var seo = await _context.Seo.Skip(request.Skip).Take(request.Quantity).Select(s => new Seo { SeoId = s.SeoId, MetaTagTitle = s.MetaTagTitle }).ToListAsync();
            if (seo.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.Seo = seo;
            return Ok(result);
        }

        [HttpPost("getSearchMethodForSeo")]
        public async Task<IActionResult> GetSearchMethodForSeo(string Name, int Quantity)
        {
            var result = new SeoResponse();

            var seo = await _context.Seo.Take(Quantity).Where(c => c.MetaTagTitle.StartsWith(Name) || c.MetaTagTitle.Contains(Name) || c.MetaTagTitle.EndsWith(Name)).Select(p => new Seo { SeoId = p.SeoId, MetaTagTitle = p.MetaTagTitle }).ToListAsync();
            if (seo.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.Seo = seo;
            return Ok(result);
        }
    }
}
