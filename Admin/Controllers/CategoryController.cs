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
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;

        public CategoryController(ILogger<CategoryController> logger, IDbService dbService, IMapper mapper)
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
                var seo = await _dbService.GetList<DbProductCategory>(skip, qty);
                if (seo.Count == 0)
                {
                    return BadRequest("No data with provided parameters");
                }
                var result = seo.OrderBy(s => s.UpdateDate).Select(s => new ProductCategory { Id = s.Id, Name = s.Name });

                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);

            }
        }

        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var seo = await _dbService.Get<DbProductCategory>(id);
                if (seo is null)
                {
                    return BadRequest("No seo with provided Id");
                }
                var result = _mapper.Map<ProductCategory>(seo);
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
                var seo = await _dbService.Find<DbProductCategory>(c => c.Name.StartsWith(Name) || c.Name.Contains(Name) || c.Name.EndsWith(Name));
                var result = seo.OrderBy(s => s.UpdateDate).Select(s => new ProductCategory { Id = s.Id, Name = s.Name });
                if (result.Any())
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
        public async Task<IActionResult> Update(ProductCategory productCategory)
        {
            try
            {
                var DbProductCategory = _mapper.Map<DbProductCategory>(productCategory);
                var result = await _dbService.Save<DbProductCategory>(DbProductCategory);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);

            }
        }

        [HttpPost()]
        public async Task<IActionResult> Create(ProductCategory productCategory)
        {
            try
            {
                var dbProductCategory = _mapper.Map<DbProductCategory>(productCategory);
                var result = await _dbService.Save<DbProductCategory>(dbProductCategory);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);

            }
        }

        [HttpDelete()]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var result = await _dbService.Archive<DbProductCategory>(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

    }
}
