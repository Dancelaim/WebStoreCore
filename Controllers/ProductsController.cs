//using System;
//using System.Collections.Generic;
//using System.Data.Common;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using System.IO;

//using WebUI.Controllers;
//using WebUI.Models;

//using WowCarry.Domain.Abstract;
//using WowCarry.Domain.Entities;

//namespace WowCarry.WebUI.Controllers
//{
//    public class ProductsController : Controller
//    {
//        IEntityRepository EntityRepository;
//        public int pageSize = 3;
//        public ProductsController(IEntityRepository entityRepo)
//        {
//            EntityRepository = entityRepo;
//        }
//        public ViewResult List(string selectedGame, string categoryName,int page = 1)
//        {
//            if (!string.IsNullOrEmpty(selectedGame))
//            {
//                Session["SelectedGame"] = EntityRepository.Products.Where(p => p.ProductGame.GameShortUrl == selectedGame).Select(p => p.ProductGame.GameName).FirstOrDefault();
//            }

//            ProductsListViewModel model = new ProductsListViewModel
//            {
//                Products = EntityRepository.Products.Where(p => categoryName == null || p.ProductCategory.ProductCategoryName == categoryName && p.ProductGame.GameShortUrl == selectedGame)
//                .OrderBy(p => p.ProductUpdateDate)
//                .Skip((page - 1) * pageSize)
//                .Take(pageSize),
//                PagingInfo = new PagingInfo
//                {
//                    CurrentPage = page,
//                    ItemsPerPage = pageSize,
//                    TotalItems = categoryName == null ? EntityRepository.Products.Count() : EntityRepository.Products.Where(p => p.ProductCategory.ProductCategoryName == categoryName && p.ProductGame.GameShortUrl == (string)Session["SelectedGame"]).Count()
//                },
//                CurrentCategory = categoryName,
//                productCategory = EntityRepository.Products.Where(p => categoryName == null || p.ProductCategory.ProductCategoryName == categoryName).Select(p => p.ProductCategory).FirstOrDefault()
//            };
//            return View(model);
//        }
//    }
//}