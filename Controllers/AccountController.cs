//using System.Linq;
//using System.Web.Mvc;
//using WowCarry.Domain.Entities;
//using WowCarry.Domain.Abstract;
//using WebUI.Models;
//using System;
//using System.Collections.Generic;
//using System.Web.Security;
//using Microsoft.AspNet.Identity;

//namespace WowCarry.WebUI.Controllers
//{
//    public class AccountController : Controller
//    {
//        IEntityRepository EntityRepository;
//        public AccountController(IEntityRepository entityRepo)
//        {
//            EntityRepository = entityRepo;
//        }
//        public ViewResult Account()
//        {
//            if (User.Identity.IsAuthenticated)
//            {
//                Customers Customer =  EntityRepository.Customers.Where(c => c.Email == User.Identity.Name).FirstOrDefault();
//                return View(Customer);
//            }
//            return View();
//        }
//        public ViewResult AccountOrders()
//        {
//            Customers Customer = EntityRepository.Customers.Where(c => c.Email == User.Identity.Name).FirstOrDefault();
//            IEnumerable<Orders> orders = EntityRepository.Orders.Where(o => o.CustomerId == Customer.CustomerId);
//            return View(orders);
//        }
//        public ViewResult AccountPersonalInfo()
//        {
//            return View();
//        }
//        public ViewResult AccountPasswordChange()
//        {
//            return View();
//        }
//        public ViewResult AccountInviteLink()
//        {
//            return View();
//        }

//    }
//}