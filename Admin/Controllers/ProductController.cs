//using Admin.ApiModels.Request;
//using Admin.ApiModels.Response;
//using Admin.Core;
//using Admin.Models;
//using AutoMapper;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Admin.Controllers
//{
//    [ApiController]
//    [Route("admin/[controller]")]
//    public class ProductController : ControllerBase
//    {
//        private readonly IDbHelper _dbHelper;
//        private readonly ILogger<ProductController> _logger;


//        public ProductController(ILogger<ProductController> logger, IDbHelper dbHelper)
//        {
//            _dbHelper = dbHelper;
//            _logger = logger;
//        }
//        [HttpGet("test")]
//        public string Test()
//        {
//            _logger.Log(LogLevel.Information, "Ocelot Test");
//            return "OCELOT test successfull";
//        }
//        [HttpPost("getProducts")]
//        public async Task<IActionResult> GetProducts(int skip, int qty)
//        {
//            _logger.Log(LogLevel.Information, $"ProductController;GetProducts;Skip:{skip};QTY:{qty};REQUEST");
//            var result = new ProductsResponse();

//            var products = await _dbHelper.GetProducts(skip,qty);

//            if (products.Count == 0)
//            {
//                result.Code = -100;
//                result.Message = "Can't get products with given parameters.";
//                _logger.Log(LogLevel.Warning, $"ProductController;GetProducts;RESPONSE;");
//                return Ok(result);
//            }

//            result.Code = 100;
//            result.Message = "Success";
//            result.Products = products;
//            return Ok(result);
//        }

//        [HttpGet("getProduct")]
//        public async Task<IActionResult> GetProduct(Guid ProductId)
//        {
//            var response = new ProductResponse();

//            var result = await _dbHelper.GetProduct(ProductId);

//            if (result == null)
//            {
//                response.Code = -100;
//                response.Message = "Can't get products with given parameters.";
//                return Ok(response);
//            }

//            response.Code = 100;
//            response.Message = "Success";
//            response.Product = result;
//            return Ok(response);
//        }

//        [HttpGet("getDescriptionByProduct")]
//        public async Task<IActionResult> GetDescriptionByProduct(Guid ProductId)
//        {
//           var result =  await _dbHelper.GetDescriptionByProduct(ProductId);
//            return Ok(result);  
//        }
//        [HttpPost("getSearchMethodForProduct")]
//        public async Task<IActionResult> GetSearchMethodForProduct(string Name, int Quantity)
//        {
//            var result = new ProductsResponse();
//            var products = await _dbHelper.GetSearchMethodForProduct(Name,Quantity);
//            if (products.Count == 0)
//            {
//                result.Code = -100;
//                result.Message = "Can't get products with given parameters.";
//                return Ok(result);
//            }

//            result.Code = 100;
//            result.Message = "Success";
//            result.Products = products;
//            return Ok(result);
//        }
//        [HttpPut("updateProduct")]
//        public async Task<IActionResult> UpdateProduct(ProductRequest request)
//        {
//            if (ModelState.IsValid)
//                if (await _dbHelper.UpdateProduct(request) == 3)
//                    return Ok();

//            return BadRequest();

//        }

//        [HttpPost("createProduct")]
//        public async Task<IActionResult> CreateProduct(ProductRequest request)
//        {
//            if (ModelState.IsValid)
//                if(await _dbHelper.CreateProduct(request)==3)
//                    return Ok();

//            return BadRequest();
//        }
//        [HttpDelete("deleteProduct")]
//        public async Task<IActionResult> DeleteProduct(Guid ProductId)
//        {
//            await _dbHelper.DeleteProduct(ProductId);
//            return Ok();
//        }
//    }
//}
