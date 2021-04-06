using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

using System;
using System.Text;
using System.Web;


    public static class PagingHelper
    {
        public static HtmlString PageLinks(this IHtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder litag = new TagBuilder("li");
                TagBuilder atag = new TagBuilder("a");
                atag.MergeAttribute("href", pageUrl(i));
                atag.InnerHtml.SetContent(i.ToString());
                if (i == pagingInfo.CurrentPage)
                {
                    atag.AddCssClass("selected");
                    atag.AddCssClass("btn-primary");
                }
                atag.AddCssClass("btn btn-default");
                litag.InnerHtml.SetContent(atag.ToString());
                result.Append(litag.ToString());
            }
            return new HtmlString(result.ToString());
        }
    }
