//using System.Linq;
//using System.Web.Mvc;
//using WowCarry.Domain.Entities;
//using WowCarry.Domain.Abstract;
//using WebUI.Models;
//using System;
//using System.Collections.Generic;
//using System.Text.RegularExpressions;

//namespace WowCarry.WebUI.Controllers
//{
//    public  class BlogController : Controller
//    {

//        IEntityRepository EntityRepository;
//        public BlogController(IEntityRepository EntityRep)
//        {
//            EntityRepository = EntityRep;
//        }
//        public ViewResult Article(Guid articleId)
//        {
//            Article result = EntityRepository.Articles.Where(a => a.ArticleId == articleId).FirstOrDefault();
//            return View(result);
//        }
//        public ViewResult Articles(string game)
//        {
//            IEnumerable<Article> result = EntityRepository.Articles.Where(a => a.ProductGame.GameName == game);
//            return View(result);
//        }
//        public ViewResult Blog()
//        {
//            IEnumerable<Article> result = EntityRepository.Articles;
//            return View(result);
//        }
//        public ViewResult TagSearch(string Tag)
//        {
//            List<string> resultTags = new List<string>();

//            var tags = string.Join(", ", EntityRepository.Articles.Select(a => a.Tags).Distinct());

//            foreach (var singleTag in tags.Split(',').Distinct())
//            {
//                resultTags.Add(singleTag);
//            }

//            TagSearchViewModel result = new TagSearchViewModel()
//            {
//                articles = EntityRepository.Articles.Where(a=>a.Tags.Contains(Tag.Trim())),
//                tags = resultTags
//            };
//            return View(result);
//        }
//        public PartialViewResult LatestPosts()
//        {
//            IEnumerable<Article> result = EntityRepository.Articles.OrderBy(a => a.ArticlePostTime).Take(4);
//            return PartialView(result);
//        }
//    }
//}