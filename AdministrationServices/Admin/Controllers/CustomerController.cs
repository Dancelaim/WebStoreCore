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
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly WowCarryContext _context;
        private IMapper _mapper;

        public CustomerController(ILogger<CustomerController> logger, WowCarryContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("getCustomer")]
        public async Task<IActionResult> GetCustomer(CustomerRequest request)
        {
            var result = new CustomerResponse();

            var customer = await _context.Customers.Skip(request.Skip).Take(request.Quantity).Select(s => new Customer { CustomerId = s.Id, Name = s.Name }).ToListAsync();
            if (customer.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.Customer = customer;
            return Ok(result);
        }
        [HttpPost("getSearchMethodForCustomer")]
        public async Task<IActionResult> GetSearchMethodForCustomer(string Name, CustomerRequest request)
        {
            var result = new CustomerResponse();

            var customer = await _context.Customers.Take(request.Quantity).Where(c => c.Name.StartsWith(Name) || c.Name.Contains(Name) || c.Name.EndsWith(Name)).Select(p => new Customer { CustomerId = p.Id, Name = p.Name }).ToListAsync();
            if (customer.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.Customer = customer;
            return Ok(result);
        }
    }
}
