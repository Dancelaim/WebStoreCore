using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using WowCarryCore.Models;

namespace WowCarryCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private WowCarryContext _context;

        public HomeController(ILogger<HomeController> logger, WowCarryContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            HttpContext.Session.Remove("SelectedGame");

            
            return View();
        }
        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
        [Route("AboutUs")]
        public ViewResult AboutUs()
        {
            return View();

        }
        [Route("Contacts")]
        public ViewResult Contacts()
        {
            return View();
        }
        [Route("FAQ")]
        public ViewResult FAQ()
        {
            return View();
        }
        [Route("Terms")]
        public ViewResult Terms()
        {
            return View();
        }
        [Route("CarryCoins")]
        public ViewResult CarryCoins()
        {
            return View();
        }
        [HttpPost]
        public void SetSessionData(Dictionary<string, string> dict)
        {
            if (dict.Count() > 0)
            {
                foreach (var keyValuePair in dict)
                {
                    HttpContext.Session.SetString(keyValuePair.Key, keyValuePair.Value);
                }
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        // TODO :Воткнуть в абстрактный общий контроллер для общего функционала подумать для чего прикрутить
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Headers.ContainsKey("User-Agent"))
            {
                // получаем заголовок User-Agent
                var useragent = context.HttpContext.Request.Headers["User-Agent"].FirstOrDefault();
                // сравниваем его значение
                if (useragent.Contains("MSIE") || useragent.Contains("Trident"))
                {
                    context.Result = Content("Internet Explorer is not supported");
                }
            }
            base.OnActionExecuting(context);
        }
    }
}
