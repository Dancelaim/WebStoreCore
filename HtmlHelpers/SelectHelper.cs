using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Html;

namespace HtmlHelpers
{
    public static class SelectHelper
    {
        public static string MakeActiveClass(this UrlHelper urlHelper, string controller)
        {
            string result = "active";

            string controllerName = urlHelper.ActionContext.RouteData.Values["controller"].ToString();

            if (!controllerName.Equals(controller, StringComparison.OrdinalIgnoreCase))
            {
                result = null;
            }

            return result;
        }
        public static string IsSelected(this IHtmlHelper html, string category)
        {
            const string cssClass = "active";
            var currentCategory = html.ViewContext.HttpContext.Request.Query["categoryName"];

            return category == currentCategory ? cssClass : String.Empty;
        }
        public static string AdminIsSelected(this IHtmlHelper html, string item = null)
        {
            const string cssClass = "active";
            var currentAction = (string)html.ViewContext.RouteData.Values["action"];

            return item == currentAction ? cssClass : String.Empty;
        }
        //TO DO: MOVE TO ANOTHER HELPER 
        //public static IDisposable BeginCollectionItem<TModel>(this HtmlHelper<TModel> html, string collectionName)
        //{
        //    string collectionIndexFieldName = String.Format("{0}.Index", collectionName);
        //    string itemIndex = GetCollectionItemIndex(collectionIndexFieldName);
        //    string collectionItemName = String.Format("{0}[{1}]", collectionName, itemIndex);

        //    TagBuilder indexField = new TagBuilder("input");
        //    indexField.MergeAttributes(new Dictionary<string, string>() {
        //                { "name", String.Format("{0}.Index", collectionName) },
        //                { "value", itemIndex },
        //                { "type", "hidden" },
        //                { "autocomplete", "off" }
        //                    });

        //    html.ViewContext.Writer.WriteLine(indexField.ToString(TagRenderMode.SelfClosing));
        //    return new CollectionItemNamePrefixScope(html.ViewData.TemplateInfo, collectionItemName);
        //}

        //private class CollectionItemNamePrefixScope : IDisposable
        //{
        //    private readonly TemplateInfo _templateInfo;
        //    private readonly string _previousPrefix;

        //    public CollectionItemNamePrefixScope(TemplateInfo templateInfo, string collectionItemName)
        //    {
        //        this._templateInfo = templateInfo;

        //        _previousPrefix = templateInfo.HtmlFieldPrefix;
        //        templateInfo.HtmlFieldPrefix = collectionItemName;
        //    }

        //    public void Dispose()
        //    {
        //        _templateInfo.HtmlFieldPrefix = _previousPrefix;
        //    }
        //}
        //private static string GetCollectionItemIndex(string collectionIndexFieldName)
        //{
        //    Queue<string> previousIndices = (Queue<string>)HttpContext.Current.Items[collectionIndexFieldName];
        //    if (previousIndices == null)
        //    {
        //        HttpContext.Current.Items[collectionIndexFieldName] = previousIndices = new Queue<string>();

        //        string previousIndicesValues = HttpContext.Current.Request[collectionIndexFieldName];
        //        if (!String.IsNullOrWhiteSpace(previousIndicesValues))
        //        {
        //            foreach (string index in previousIndicesValues.Split(','))
        //                previousIndices.Enqueue(index);
        //        }
        //    }

        //    return previousIndices.Count > 0 ? previousIndices.Dequeue() : Guid.NewGuid().ToString();
        //}
    }
}

