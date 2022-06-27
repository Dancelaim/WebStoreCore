using Admin.ApiModels.Request;
using Admin.ApiModels.Response;
using Admin.Core;
using Admin.Entities;
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
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;

        public SeoController(ILogger<SeoController> logger, IDbService dbService, IMapper mapper)
        {  
            _logger = logger;
            _dbService = dbService;
            _mapper = mapper;
        }

        [HttpGet("getList")]
        public async Task<IActionResult> GetSeoList(int skip, int qty)
        {
            var seo = await _dbService.GetList<DbSeo>(skip, qty);
            if (seo.Count == 0)
            {
                return BadRequest("No data with provided parameters");
            }
            var result = seo.Select(s => new Seo { Id = s.Id, MetaTagTitle = s.MetaTagTitle });

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetSeo(Guid seoId)
        {
            var seo = await _dbService.Get<DbSeo>(seoId);
            if (seo is null)
            {
                return BadRequest("No seo with provided Id");
            }
            var result = _mapper.Map<Seo>(seo);
            return Ok(result);
        }

        [HttpGet("getSearchMethodForSeo")]
        public async Task<IActionResult> GetSearchMethodForSeo(string Name, int Quantity)
        {
            //var result = new SeoResponse();

            //var seo = await _context.Seo.Take(Quantity).Where(c => c.MetaTagTitle.StartsWith(Name) || c.MetaTagTitle.Contains(Name) || c.MetaTagTitle.EndsWith(Name)).Select(p => new Seo { SeoId = p.Id, MetaTagTitle = p.MetaTagTitle }).ToListAsync();
            //if (seo.Count == 0)
            //{
            //    result.Code = -100;
            //    result.Message = "Can't get products with given parameters.";
            //    return Ok(result);
            //}

            //result.Code = 100;
            //result.Message = "Success";
            //result.Seo = seo;
            return Ok("Not yet implemented");
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateSeo(Seo seo)
        {
            if (ModelState.IsValid)
            {
                var dbSeo = _mapper.Map<DbSeo>(seo);
                var result = await _dbService.Save<DbSeo>(dbSeo);
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost()]
        public async Task<IActionResult> CreateSeo(Seo seo)
        {
            if (ModelState.IsValid)
            {
                var dbSeo = _mapper.Map<DbSeo>(seo);
                var result = await _dbService.Save<DbSeo>(dbSeo);
                return Ok(result);
            }

            return BadRequest();
        }
    }
}
