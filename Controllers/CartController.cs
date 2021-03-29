//using System.Linq;
//using System.Web.Mvc;
//using WowCarry.Domain.Entities;
//using WowCarry.Domain.Abstract;
//using WebUI.Models;
//using System;

//namespace WowCarry.WebUI.Controllers
//{
//    public  class CartController : Controller
//    {

//        IEntityRepository EntityRepository;
//        public CartController(IEntityRepository EntityRep)
//        {
//            EntityRepository = EntityRep;
//        }
//        public PartialViewResult CartPopUp(Cart cart)
//        {
//            return PartialView(cart);
//        }
//        [HttpPost]
//        public ActionResult RemoveFromCart(Cart cart,Guid productId)
//        {
//            Product product = EntityRepository.Products.FirstOrDefault(p => p.ProductId == productId);

//            if (product != null)
//            {
//                cart.RemoveLine(product);
//            }
//            return PartialView("CartPopUp", cart);
//        }
//        public PartialViewResult UpdateCart(Cart cart)
//        {
//            return PartialView("CartPopUp", cart);
//        }
//    }
//}