﻿using Admin.ApiModels.Request;
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
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ApplicationContext _context;
        private IMapper _mapper;

        public ProductController(ILogger<ProductController> logger, ApplicationContext context, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
            _context = context;
        }
        [HttpGet("test")]
        public string Test()
        {
            return "OCELOT test successfull";
        }

        [HttpPost("getProducts")]
        public async Task<IActionResult> GetProducts(ProductsRequest request)
        {
            var result = new ProductsResponse();

            var products = await _context.Product.Skip(request.Skip).Take(request.Quantity).Select(p => new Product { ProductId = p.ProductId, ProductName = p.ProductName }).ToListAsync();
            if (products.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.Products = products;
            return Ok(result);
        }
        
        [HttpGet("getProduct")]
        public async Task<IActionResult> GetProduct(Guid ProductId)
        {
            var response = new ProductResponse();
            var result = await _context.Product.Where(p => p.ProductId == ProductId).Select(p => new {p, p.ProductPrices, p.ProductCategory, p.ProductSeo,p.ProductGame}).FirstOrDefaultAsync();
            if (result == null)
            {
                response.Code = -100;
                response.Message = "Can't get products with given parameters.";
                return Ok(response);
            }
            
            response.Product = _mapper.Map<Product>(result.p);
            //Todo: Fix pricec foreign keys.
            response.Product = _mapper.Map(result.ProductPrices.First(), response.Product);
            response.Product = _mapper.Map(result.ProductGame, response.Product);
            response.Product = _mapper.Map(result.ProductCategory, response.Product);
            response.Product = _mapper.Map(result.ProductSeo, response.Product);

            response.Code = 100;
            response.Message = "Success";
            return Ok(response);
        }
        
        [HttpPost("getDescriptionByProduct")]
        public async Task<IActionResult> GetDescriptionByProduct(Guid ProductId)
        {
            var description = await _context.Product.Where(p => p.ProductId == ProductId).Select(p => p.ProductDescription).FirstOrDefaultAsync();
            var result = _mapper.Map<DescriptionResponse>(description);
            result.Code = 100;
            result.Message = "Success";
            return Ok(result);
        }
    }
}
