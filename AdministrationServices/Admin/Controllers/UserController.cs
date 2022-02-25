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
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly ApplicationContext _context;
        private IMapper _mapper;

        public UserController(ILogger<UserController> logger, ApplicationContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
    
        [HttpPost("getUsers")]
        public async Task<IActionResult> GetUsers(UsersRequest request)
        {
            var result = new UsersResponse();

            var users = await _context.Users.Select(p => new User { UserId = p.Id, Name = p.Name }).ToListAsync();
            if (users.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.User = users;
            return Ok(result);
        }
        [HttpPost("getSearchMethodForUsers")]
        public async Task<IActionResult> GetSearchMethodForUsers(string Name, int Quantity)
        {
            var result = new UsersResponse();

            var users = await _context.Users.Take(Quantity).Where(c => c.Name.StartsWith(Name) || c.Name.Contains(Name) || c.Name.EndsWith(Name)).Select(p => new User { UserId = p.Id, Name = p.Name }).ToListAsync();
            if (users.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.User = users;
            return Ok(result);
        }
    }
}
