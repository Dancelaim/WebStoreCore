using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Controllers;

using WowCarryCore.Models;

namespace WebUI.Controllers
{
    public class GamePageController : Controller
    {
        private readonly ILogger<GamePageController> _logger;
        private WowCarryContext _context;
        public GamePageController(ILogger<GamePageController> logger, WowCarryContext context)
        {
            _logger = logger;
            _context = context;
        }
        public ActionResult GameDetails(string currentGame)
        {
            ProductGame result = _context.Products.Where(p => p.ProductGame.GameName == currentGame).Select(p => p.ProductGame).FirstOrDefault();
            ViewData["SelectedGame"] = result.GameName;
            HttpContext.Session.SetString("SelectedGame", result.GameName);
            return View(result);
        }
    }
}