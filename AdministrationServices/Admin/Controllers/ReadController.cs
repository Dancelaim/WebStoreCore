using Admin.ApiModels;
using Admin.ApiModels.Request;
using Admin.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    public class ReadController : ControllerBase
    {
        private readonly ILogger<ReadController> _logger;
        private ApplicationContext _context;

        public ReadController(ILogger<ReadController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        //public ActionResult GetProduct(ProductRequest request)
        //{
        //        //var response = new ProductResponse();
        //        var product = _context.Product.Skip(request._skip).Take(request.quantity);
        //}
    }
}
