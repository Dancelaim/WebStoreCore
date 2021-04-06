using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.IO;

using WebUI.Controllers;
using Microsoft.AspNetCore.Mvc;
using WowCarryCore.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

public class ProductsController : Controller
{
    public int pageSize = 3;
    private readonly ILogger<ProductsController> _logger;
    private WowCarryContext _context;

    public ProductsController(ILogger<ProductsController> logger, WowCarryContext context)
    {
        _logger = logger;
        _context = context;
    }

    public ViewResult List(string selectedGame, string categoryName, int page = 1)
    {
        if (!string.IsNullOrEmpty(selectedGame))
        {
            HttpContext.Session.SetString("SelectedGame", selectedGame);
            ViewData["SelectedGame"] = selectedGame;
        }
        else
        {
            selectedGame = HttpContext.Session.GetString("SelectedGame");
            ViewData["SelectedGame"] = HttpContext.Session.GetString("SelectedGame");
        }

        var products = _context.Products.Where(p => categoryName == null || p.ProductCategory.ProductCategoryName == categoryName && p.ProductGame.GameName == selectedGame).Include(p=>p.ProductPrices).Include(p => p.ProductSeo).OrderBy(p => p.ProductUpdateDate).Skip((page - 1) * pageSize).Take(pageSize);

        PagingInfo pi = new PagingInfo
        {
            CurrentPage = page,
            ItemsPerPage = pageSize,
            TotalItems = categoryName == null ? _context.Products.Count() : products.Count()
        };
        ViewData["CurrentCategory"] = categoryName;

        return View(products);
    }
}
    
