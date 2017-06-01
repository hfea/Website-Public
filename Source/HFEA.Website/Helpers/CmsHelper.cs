using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using umbraco.NodeFactory;

namespace HFEA.Web.Helpers
{
    public class CmsHelper
    {
        public static string GetUrlById(string nodeId)
        {
            int id;
            int.TryParse(nodeId, out id);

            return GetUrlById(id);
        }

        public static string GetUrlById(int nodeId)
        {
            return Umbraco.Web.UmbracoContext.Current.UrlProvider.GetUrl(nodeId);
        }

        public static string GetUrlById(int nodeId, bool ensureTrailingSlash)
        {
            var url = GetUrlById(nodeId);

            if (ensureTrailingSlash && !string.IsNullOrEmpty(url) && url[url.Length - 1] != '/')
            {
                url += "/";
            }

            return url;
        }

        public static string GetDynamicUrlByNodeId(int nodeId, string dynamicPart, bool ensureTrailingSlash)
        {
            string result = string.Empty;

            var node = new Node(nodeId);

            if (node.Parent != null)
            {
                result = GetUrlById(node.Parent.Id, true) + dynamicPart;

                if (ensureTrailingSlash && result[result.Length - 1] != '/')
                {
                    result += "/";
                }
            }

            return result;
        }
    }
}