//using System;
//using System.Text;
//using System.Web;
//using System.Web.Mvc;

//using WebUI.Models;

//namespace WebUI.HtmlHelpers
//{
//    public static class PagingHelper
//    {
//        public static MvcHtmlString PageLinks(this HtmlHelper html,PagingInfo pagingInfo,Func<int, string> pageUrl)
//        {
//            StringBuilder result = new StringBuilder();
//            for (int i = 1; i <= pagingInfo.TotalPages; i++)
//            {
//                TagBuilder litag = new TagBuilder("li");
//                TagBuilder atag = new TagBuilder("a");                
//                atag.MergeAttribute("href", pageUrl(i));
//                atag.InnerHtml = i.ToString();
//                if (i == pagingInfo.CurrentPage)
//                {
//                    atag.AddCssClass("selected");
//                    atag.AddCssClass("btn-primary");
//                }
//                atag.AddCssClass("btn btn-default");
//                litag.InnerHtml = atag.ToString();
//                result.Append(litag.ToString());
//            }
//            return MvcHtmlString.Create(result.ToString());
//        }
//    }
//}