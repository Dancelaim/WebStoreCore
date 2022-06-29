using Admin.ApiModels.Request;
using Admin.ApiModels.Response;
using Admin.Core;
using Admin.Entities;
using Admin.Models;

using AutoMapper;

using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> GetList(int skip, int qty)
        {
            try
            {
                var seo = await _dbService.GetList<DbSeo>(skip, qty);
                if (seo.Count == 0)
                {
                    return BadRequest("No data with provided parameters");
                }
                var result = seo.OrderBy(s => s.UpdateDate).Select(s => new Seo { Id = s.Id, MetaTagTitle = s.MetaTagTitle });

                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);

            }
        }

        [HttpGet]
        public async Task<IActionResult> Get(Guid seoId)
        {
            try
            {
                var seo = await _dbService.Get<DbSeo>(seoId);
                if (seo is null)
                {
                    return BadRequest("No seo with provided Id");
                }
                var result = _mapper.Map<Seo>(seo);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);

            }
        }

        [HttpGet("SearchFor")]
        public async Task<IActionResult> SearchFor(string Name)
        {
            try
            {
                var seo = await _dbService.Find<DbSeo>(c => c.MetaTagTitle.ToLower().StartsWith(Name.ToLower()) || c.MetaTagTitle.ToLower().Contains(Name.ToLower()) || c.MetaTagTitle.ToLower().EndsWith(Name.ToLower()));
                var result = seo.OrderBy(s => s.UpdateDate).Select(s => new Seo { Id = s.Id, MetaTagTitle = s.MetaTagTitle });
                if (!result.Any())
                {
                    return Ok("Can't get products with given parameters.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpPut()]
        public async Task<IActionResult> Update(Seo seo)
        {
            try
            {
                var dbSeo = _mapper.Map<DbSeo>(seo);
                var result = await _dbService.Save<DbSeo>(dbSeo);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);

            }
        }

        [HttpPost()]
        public async Task<IActionResult> Create(Seo seo)
        {
            try
            {
                var dbSeo = _mapper.Map<DbSeo>(seo);
                var result = await _dbService.Save<DbSeo>(dbSeo);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);

            }
        }

        [HttpDelete()]
        public async Task<IActionResult> Delete(Guid seoId)
        {
            try
            {
                var result = await _dbService.Archive<DbSeo>(seoId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

    }
}
