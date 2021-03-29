//using System.Web.Mvc;
//using System.Web.Security;
//using WowCarry.Domain.Entities;
//using WebUI.Models;
//using System.Linq;
//using System.Net.Mail;
//using System;

//namespace WebUI.Controllers
//{
//    public class LoginController : Controller
//    {
//        public ActionResult Login(bool isWebView = false)
//        {
//            if (isWebView)
//            {
//                return PartialView("CustomerLogin");
//            }
//            else
//            {
//                return View();
//            }
//        }
//        public PartialViewResult Registration()
//        {
//            return PartialView();
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Login(LoginViewModel model)
//        {
//            using (WowCarryEntities context = new WowCarryEntities())
//            {
//                bool IsValidUser = context.Users.Any(user => user.UserName.ToLower() == model.UserName.ToLower() && user.UserPassword == model.Password);
//                if (IsValidUser)
//                {
//                    FormsAuthentication.SetAuthCookie(model.UserName, false);
//                    return  RedirectToAction("Admin", "Admin");
//                }
//                ModelState.AddModelError("", "Invalid Username or Password");
//                return PartialView();
//            }
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public bool AjaxLogin(string email, string password)
//        {
//            using (WowCarryEntities context = new WowCarryEntities())
//            {
//                bool IsValidUser = context.Customers.Any(user => user.Email.ToLower() == email.ToLower() && user.Password == password);
//                if (IsValidUser)
//                {
//                    FormsAuthentication.SetAuthCookie(email, false);
//                    return true;
//                }
//                return false;
//            }
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public string AjaxRegistration(string CustomerName,string Email,string Password)
//        {
//            var addr = new MailAddress(Email);
//            if (addr.Address == Email)
//            {
//                using (WowCarryEntities context = new WowCarryEntities())
//                {
//                    Customers newCustomer = new Customers()
//                    {
//                        CustomerId = Guid.NewGuid(),
//                        Name = CustomerName,
//                        Email = Email,
//                        Password = Password
//                    };
//                    context.Customers.Add(newCustomer);
//                    context.SaveChanges();
//                }
//                FormsAuthentication.SetAuthCookie(Email, false);
//                return "success";
//            }
//            return "failed";


//        }
//        public ActionResult Logout()
//        {
//            FormsAuthentication.SignOut();
//            return RedirectToAction("Login");
//        }
//        public ActionResult CustomerLogout()
//        {
//            FormsAuthentication.SignOut();
//            return RedirectToAction("Home", "HomePage");
//        }

//    }
//}