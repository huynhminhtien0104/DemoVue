using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDemo.Models
{
    public static class Helpers
    {
        public static IHtmlString LoadFile(string webpath)
        {
            HtmlString returnContent = new HtmlString("");
            if (!string.IsNullOrWhiteSpace(webpath))
            {
                string filepath = System.Web.Hosting.HostingEnvironment.MapPath(webpath);
                if (File.Exists(filepath))
                {
                    string content = File.ReadAllText(filepath);
                    if (!string.IsNullOrWhiteSpace(content))
                    {
                        returnContent = new HtmlString(content);
                    }
                }
            }
            return returnContent;
        }

        public static MvcHtmlString GetClientModel<TModel>(this HtmlHelper helper) where TModel : new() => GetClientModel(helper, new TModel());

        public static MvcHtmlString GetClientModel<TModel>(this HtmlHelper helper, TModel model)
        {
            string escapedJson = JsonConvert.SerializeObject(model, Newtonsoft.Json.Formatting.None);
            MvcHtmlString ret = new MvcHtmlString($"{escapedJson}");
            return ret;
        }
    }
}