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
    public class RankController : ControllerBase
    {
        private readonly ILogger<RankController> _logger;
        private readonly WowCarryContext _context;
        private IMapper _mapper;

        public RankController(ILogger<RankController> logger, WowCarryContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("getRank")]
        public async Task<IActionResult> GetRank(RankRequest request)
        {
            var result = new RankResponse();

            var rank = await _context.Ranks.Skip(request.Skip).Take(request.Quantity).Select(p => new Ranks { RankId = p.Id, Name = p.Name }).ToListAsync();
            if (rank.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.Ranks = rank;
            return Ok(result);
        }
        [HttpPost("getSearchMethodForRank")]
        public async Task<IActionResult> GetSearchMethodForRank(RankRequest request, string Name)
        {
            var result = new RankResponse();

            var rank = await _context.Ranks.Take(request.Quantity).Where(c => c.Name.StartsWith(Name) || c.Name.Contains(Name) || c.Name.EndsWith(Name)).Select(p => new Ranks { RankId = p.Id, Name = p.Name }).ToListAsync();
            if (rank.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.Ranks = rank;
            return Ok(result);
        }
    }
}
