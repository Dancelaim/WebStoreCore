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
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly WowCarryContext _context;
        private IMapper _mapper;

        public OrderController(ILogger<OrderController> logger, WowCarryContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("getOrders")]
        public async Task<IActionResult> GetOrders(OrdersRequest request)
        {
            var result = new OrdersResponse();

            var orders = await _context.Orders.Skip(request.Skip).Take(request.Quantity).Select(p => new Order { OrderId = p.Id, Email = p.Email }).ToListAsync();
            if (orders.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.Orders = orders;
            return Ok(result);
        }
        [HttpPost("getSearchMethodForOrder")]
        public async Task<IActionResult> GetSearchMethodForOrder(string Email, OrdersRequest request)
        {
            var result = new OrdersResponse();

            var orders = await _context.Orders.Take(request.Quantity).Where(c => c.Email.StartsWith(Email) || c.Email.Contains(Email) || c.Email.EndsWith(Email)).Select(p => new Order { OrderId = p.Id, Email = p.Email }).ToListAsync();
            if (orders.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.Orders = orders;
            return Ok(result);
        }
        [HttpGet("getOrder")]
        public async Task<IActionResult> GetOrder(Guid Id)
        {
            var result = new OrderResponse();
            var order = await _context.Orders.Where(p => p.Id == Id).Select(p => new {p, p.Customer, p.OrderCustomFields, p.OrderProducts}).FirstOrDefaultAsync();
            if (result == null)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Order = _mapper.Map<Order>(order.p);
            //Todo: Fix pricec foreign keys.
            result.Order = _mapper.Map(order.OrderProducts, result.Order);
            result.Order = _mapper.Map(order.Customer, result.Order);
            result.Order = _mapper.Map(order.OrderCustomFields, result.Order);

            result.Code = 100;
            result.Message = "Success";
            return Ok(result);
        }
    }
}
