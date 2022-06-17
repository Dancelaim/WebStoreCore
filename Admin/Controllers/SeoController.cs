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
        private readonly IDbHelper _dbHelper;
        private readonly ILogger<SeoController> _logger;
        private readonly WowCarryContext _context;
        private IMapper _mapper;

        public SeoController(ILogger<SeoController> logger, WowCarryContext context, IMapper mapper , IDbHelper dbHelper)
        {
            _dbHelper = dbHelper;   
            _mapper = mapper;
            _logger = logger;
            _context = context;
        }

        [HttpPost("getSeoList")]
        public async Task<IActionResult> GetSeo(int Skip, int Quantity)
        {
            var result = new SeoResponse();

            var seo = await _context.Seo.Skip(Skip).Take(Quantity).Select(s => new Seo { SeoId = s.Id, MetaTagTitle = s.MetaTagTitle }).ToListAsync();
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

        [HttpPost("getSeo")]
        public async Task<IActionResult> GetSeo(Guid seoId)
        {
            var result = new SeoResponse();

            var seo = await _context.Seo.FirstOrDefaultAsync(s=>s.Id == seoId);
            if (seo is null)
            {
                return BadRequest("No seo with provided Id");
            }
            return Ok(seo);
        }

        [HttpPost("getSearchMethodForSeo")]
        public async Task<IActionResult> GetSearchMethodForSeo(string Name, int Quantity)
        {
            var result = new SeoResponse();

            var seo = await _context.Seo.Take(Quantity).Where(c => c.MetaTagTitle.StartsWith(Name) || c.MetaTagTitle.Contains(Name) || c.MetaTagTitle.EndsWith(Name)).Select(p => new Seo { SeoId = p.Id, MetaTagTitle = p.MetaTagTitle }).ToListAsync();
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
        [HttpPost("saveSeo")]
        public async Task<IActionResult> SaveSeo(SeoRequest request)
        {
            if (ModelState.IsValid)
                if (await _dbHelper.SaveSeo(request) == 1)
                    return Ok();
             
            return BadRequest();
        }
    }
}
