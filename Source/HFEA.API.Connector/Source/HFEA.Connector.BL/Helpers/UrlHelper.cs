using HFEA.Connector.Global;
using HFEA.Connector.Service.Constants;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Service.Helpers
{
    public class UrlHelper
    {
        private static IConfigValues config;
        public static string BaseApiUrl
        {
            get
            {
                if (ServiceLocator.IsLocationProviderSet && config == null)
                {
                    config = ServiceLocator.Current.GetInstance<IConfigValues>();
                }

                return config?.baseApiUrl;
            }
        }

        public static string GetAbsoluteApiUrl(string relativePart)
        {
            return BaseApiUrl + relativePart;
        }

        public static string GetUrlWithParameters(string url, NameValueCollection routingParameters, NameValueCollection queryParameters)
        {
            string result = string.Empty;

            result = ReplaceRoutingParameters(url, routingParameters);
            result = AddQueryParameters(result, queryParameters);

            return result;
        }

        private static string ReplaceRoutingParameters(string url, NameValueCollection parameters)
        {
            if (parameters != null && parameters.Count != 0)
            {
                foreach (var key in parameters.AllKeys)
                {
                    url = url.Replace("{" + key + "}", parameters[key]);
                }
            }

            return url;
        }

        private static string AddQueryParameters(string url, NameValueCollection parameters)
        {
            if (parameters != null && parameters.Count != 0)
            {
                string query = string.Empty;

                foreach (string key in parameters)
                {
                    query += string.Format("&{0}={1}", key, parameters[key]);
                }

                url += "?" + query.Substring(1);
            }

            return url;
        }
    }
}
