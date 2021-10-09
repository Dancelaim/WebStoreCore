using System.Linq;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WowCarryCore.Models;
using Microsoft.EntityFrameworkCore;

namespace WowCarry.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;
        private WowCarryContext _context;

        public BlogController(ILogger<BlogController> logger, WowCarryContext context)
        {
            _logger = logger;
            _context = context;
        }
        public ViewResult Article(Guid articleId)
        {
            Article result = _context.Articles.Where(a => a.ArticleId == articleId).FirstOrDefault();
            return View(result);
        }
        
        public ViewResult Articles(string game)
        {
            List<Article> result = _context.Articles.Where(a => game == null || a.ProductGame.GameName == game).ToList();
            ViewData["GameName"] = game;
            return View(result);
        }
        [Route("blogs")]
        public ViewResult Blog()
        {
            List<Article> result = _context.Articles.Include(a => a.ProductGame).ToList();
            return View(result);
        }
        public ViewResult TagSearch(string Tag)
        {
            List<string> resultTags = new List<string>();

            var tags = string.Join(",", _context.Articles.Select(a => a.Tags).Distinct());

            foreach (var singleTag in tags.Split(',').Distinct())
            {
                resultTags.Add(singleTag);
            }

            var articles = _context.Articles.Where(a => a.Tags.Contains(Tag.Trim())).ToList();
            ViewBag.resultTags = resultTags;
            return View(articles);
        }
    }
}