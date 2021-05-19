using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using WowCarryCore.Models;

public class ProductDetailsController : Controller
    {
    public int pageSize = 3;
    private readonly ILogger<ProductDetailsController> _logger;
    private WowCarryContext _context;

    public ProductDetailsController(ILogger<ProductDetailsController> logger, WowCarryContext context)
    {
        _logger = logger;
        _context = context;
    }
    public ViewResult Details(string productUrl)
    {
        Product product = _context.Products.Where(p => p.ProductSeo.UrlKeyWord == productUrl).Include(p => p.ProductDescription).Include(p => p.ProductOptions).FirstOrDefault();
        return View(product);
    }
    [HttpPost]
    public void AddToCart(Product product)
    {

    }
}

