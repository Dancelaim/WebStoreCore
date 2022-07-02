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
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> _logger;
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;

        public GameController(ILogger<GameController> logger, IDbService dbService, IMapper mapper)
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
                var ProductGame = await _dbService.GetList<DbProductGame>(skip, qty);
                if (ProductGame.Count == 0)
                {
                    return BadRequest("No data with provided parameters");
                }
                var result = ProductGame.OrderBy(s => s.UpdateDate).Select(s => new ProductGame { Id = s.Id, Name = s.Name });

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
                var ProductGame = await _dbService.Get<DbProductGame>(id);
                if (ProductGame is null)
                {
                    return BadRequest("No ProductGame with provided Id");
                }
                var result = _mapper.Map<ProductGame>(ProductGame);
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
                var ProductGame = await _dbService.Find<DbProductGame>(c => c.Name.StartsWith(Name) || c.Name.Contains(Name) || c.Name.EndsWith(Name));
                var result = ProductGame.OrderBy(s => s.UpdateDate).Select(s => new ProductGame { Id = s.Id, Name = s.Name });
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
        public async Task<IActionResult> Update(ProductGame ProductGame)
        {
            try
            {
                var DbProductGame = _mapper.Map<DbProductGame>(ProductGame);
                var result = await _dbService.Save<DbProductGame>(DbProductGame);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);

            }
        }

        [HttpPost()]
        public async Task<IActionResult> Create(ProductGame ProductGame)
        {
            try
            {
                var DbProductGame = _mapper.Map<DbProductGame>(ProductGame);
                var result = await _dbService.Save<DbProductGame>(DbProductGame);
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
                var result = await _dbService.Archive<DbProductGame>(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

    }
}
