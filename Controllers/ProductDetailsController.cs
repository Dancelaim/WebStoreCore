//using System;
//using System.Collections.Generic;
//using System.Data.Common;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//using WebUI.Models;

//using WowCarry.Domain.Abstract;
//using WowCarry.Domain.Entities;

//namespace WowCarry.WebUI.Controllers
//{
//    public class ProductDetailsController : Controller
//    {
//        IEntityRepository EntityRepository;
//        public ProductDetailsController(IEntityRepository entityRepo)
//        {
//            EntityRepository = entityRepo;
//        }
//        public ViewResult Details(string productUrl)
//        {
//            Product product = EntityRepository.Products.Where(p => p.SEO.UrlKeyWord == productUrl).FirstOrDefault();
//            return View(product);
//        }
//        [HttpPost]
//        public decimal AddToCart (Cart cart ,Guid ProductId)
//        {
//            Product product = EntityRepository.Products.Where(p => p.ProductId == ProductId).FirstOrDefault();

//            cart.AddItem(product);
//            //to do: Add MVC filter to update QTY 
//            return cart.TotalQty();
//        }
//    }
    
//}