using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HFEA.Web.Helpers
{
    public static class UrlQueryHelper
    {
        public static string SetPageParameter(string url, int pageNumber)
        {
            return AddUpdateQuery(url, Constants.CaFC.QueryString.page.ToString(), pageNumber.ToString());
        }

        public static string AddUpdateQuery(string url, NameValueCollection parameters, params string[] whiteList)
        {
            if (parameters != null)
            {
                foreach(string key in parameters)
                {
                    url = AddUpdateQuery(url, key, parameters[key], whiteList);
                }
            }

            return url;
        }

        public static string AddUpdateQuery(string url, string parameter, string value, params string[] whiteList)
        {
            Uri uri;

            if (!string.IsNullOrEmpty(url) && Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out uri))
            {
                return AddUpdateQuery(uri, parameter, value, whiteList);
            }

            return url;
        }

        public static string AddUpdateQuery(Uri uri, string parameter, string value, params string[] whiteList)
        {
            string url = string.Empty;

            if (!uri.IsAbsoluteUri)
            {
                var current = HttpContext.Current.Request.Url;

                var baseUri = new Uri(current.Scheme + "://" + current.DnsSafeHost);

                uri = new Uri(baseUri, uri.ToString());
            }

            url = uri.AbsolutePath.ToLower();

            if (!(string.IsNullOrEmpty(parameter) || string.IsNullOrEmpty(value)))
            { // here query will be filtered to contain only whitelist parameters (if any provided)
                var queryParams = HttpUtility.ParseQueryString(uri.Query ?? string.Empty);
                if (whiteList != null && whiteList.Length > 0)
                {
                    var invalidKeys = queryParams.AllKeys.Where(x => !whiteList.Contains(x)).ToList();
                    invalidKeys.ForEach(x => queryParams.Remove(x));
                }

                if (whiteList == null || !whiteList.Any() || whiteList.Contains(parameter))
                {
                    if (queryParams.AllKeys.Contains(parameter))
                    {
                        queryParams.Set(parameter, value);
                    }
                    else
                    {
                        queryParams.Add(parameter, value);
                    }
                }

                string query = string.Empty;
                for (int i = 0; i < queryParams.Count; i++)
                {
                    query += string.Format("&{0}={1}", queryParams.GetKey(i), queryParams.GetValues(i)[0]);
                }

                if (!string.IsNullOrEmpty(query))
                {
                    url += "?" + query.Remove(0, 1);
                }
            }

            return url;
        }
    }
}
