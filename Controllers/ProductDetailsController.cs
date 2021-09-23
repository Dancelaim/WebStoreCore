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
    public async void AddToCart(Guid id)
    {
        //TO DO: IMPLEMENT auth check before DB save
        var options = HttpContext.Request.Form.Where(k=>k.Key.Contains("Options"));
        decimal totalOptPrice = 0;
        string optCollection = string.Empty;
        foreach (var opt in options)
        {
            var dbOpt = await _context.ProductOptionParams.Where(p => p.ParameterName == opt.Key).FirstOrDefaultAsync();
            if (dbOpt.ParameterPrice != 0 )
            {
                optCollection += $",{dbOpt.ParameterName}";
                totalOptPrice += dbOpt.ParameterPrice;
            }
        }
        //TO DO : Get region from user location
        decimal productPrice = await _context.ProductPrices.Where(p => p.ProductId == id).Select(p => p.UsPrice).FirstOrDefaultAsync() ?? 0;

        //TO DO : fix fake user when auth is implemented
        Order newOrder = new Order
        {
            OrderId = Guid.NewGuid(),
            CustomerId = await _context.Customers.Select(c => c.CustomerId).FirstOrDefaultAsync(),
            Total = CalculateProductTotal(totalOptPrice, productPrice),
            OrderStatus = "Created",//TO DO: Create ENUM
            EmailSended = false
        };

        _context.Orders.Add(newOrder);

        OrderProduct newOrderProduct = new OrderProduct
        {
           OrderProductId= Guid.NewGuid(),
           OrderId = newOrder.OrderId,
           ProductId  = id,
           ProductOptions = optCollection,
           ProductCheckoutPrice = productPrice,
           TotalOptionsCheckoutPrice  = totalOptPrice,
        };

        _context.OrderProducts.Add(newOrderProduct);
        await _context.SaveChangesAsync();
    }

    private decimal CalculateProductTotal(decimal totalOptPrice, decimal productPrice)
    {

        //TO DO: Implement discount logic here
        return totalOptPrice + productPrice;
    }
}

