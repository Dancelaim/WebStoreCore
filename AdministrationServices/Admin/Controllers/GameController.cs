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
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> _logger;
        private readonly ApplicationContext _context;
        private IMapper _mapper;

        public GameController(ILogger<GameController> logger, ApplicationContext context, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
            _context = context;
        }

        [HttpGet("getProductGame")]
        public async Task<IActionResult> GetProductGame(ProductGameRequest request)
        {
            var result = new ProductGameResponse();

            var games = await _context.ProductGame.Select(p => new ProductGame { ProductGameId = p.Id, ProductGameName = p.GameName }).ToListAsync();
            if (games.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.ProductGames = games;
            return Ok(result);
        }

        [HttpPost("getSearchMethodForProductGame")]
        public async Task<IActionResult> GetSearchMethodForProductGame(string Name, int Quantity)
        {
            var result = new ProductGameResponse();

            var games = await _context.ProductGame.Take(Quantity).Where(c => c.GameName.StartsWith(Name) || c.GameName.Contains(Name) || c.GameName.EndsWith(Name)).Select(p => new ProductGame { ProductGameId = p.Id, ProductGameName = p.GameName }).ToListAsync();
            if (games.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.ProductGames = games;
            return Ok(result);
        }
    }
}
