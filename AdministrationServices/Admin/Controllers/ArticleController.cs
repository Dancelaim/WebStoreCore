using Admin.ApiModels.Request;
using Admin.ApiModels.Response;
using Admin.Core;
using Admin.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    [ApiController]
    [Route("admin/[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly ILogger<ArticleController> _logger;
        private readonly ApplicationContext _context;
        private IMapper _mapper;

        public ArticleController(ILogger<ArticleController> logger, ApplicationContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("getArticles")]
        public async Task<IActionResult> GetArticles(ArticleRequest request)
        {
            var result = new ArticleResponse();

            var article = await _context.Article.Skip(request.Skip).Take(request.Quantity).Select(p => new Article { ArticleId = p.ArticleId, Title = p.Title }).ToListAsync();
            if (article.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.Articles = article;
            return Ok(result);
        }
        [HttpPost("getSearchMethodForArticles")]
        public async Task<IActionResult> GetSearchMethodForArticles(ArticleRequest request , string Name)
        {
            var result = new ArticleResponse();

            var article = await _context.Article.Take(request.Quantity).Where(c => c.Title.StartsWith(Name) || c.Title.Contains(Name) || c.Title.EndsWith(Name)).Select(p => new Article { ArticleId = p.ArticleId, Title = p.Title }).ToListAsync();
            if (article.Count == 0)
            {
                result.Code = -100;
                result.Message = "Can't get products with given parameters.";
                return Ok(result);
            }

            result.Code = 100;
            result.Message = "Success";
            result.Articles = article;
            return Ok(result);
        }
    }
}
