using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHtmlHelper
{
    public static class CustomHelper
    {
        public static IHtmlString H1Tag(string value)
        {
            return new MvcHtmlString(String.Format("<h1>{0}</h1>",value));
        }
        public static IHtmlString Archor(this HtmlHelper helper,string value)
        {
            TagBuilder tag = new TagBuilder("a");
            tag.Attributes.Add("href", value);
            tag.InnerHtml="GOogLe";
            tag.Attributes.Add("target", "_blank");
            return new MvcHtmlString(tag.ToString());
        }
    }
}