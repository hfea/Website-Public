using HFEA.Connector.Contracts.Client;
using HFEA.Connector.Global;
using HFEA.Connector.Service.Constants;
using HFEA.Connector.Service.Helpers;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Service.BaseClient
{
    internal abstract class BaseApiClient
    {
        protected const string JsonHeaderString = "application/json";

        protected const string BearerHeaderString = "Bearer";

        protected string Url { get; private set; }

        protected IHfeaLogger Log { get; private set; }

        public BaseApiClient(string url)
        {
            if (string.IsNullOrEmpty(url)) throw new ArgumentNullException("URL is not set");
            
            this.Url = UrlHelper.GetAbsoluteApiUrl(url);
            this.SetLogger();

////if DEBUG
////            WebRequest.DefaultWebProxy = new WebProxy("127.0.0.1", 8888);
////endif
        }

        protected string GetUrlWithParameters(NameValueCollection routingParameters, NameValueCollection queryParameters)
        {
            return UrlHelper.GetUrlWithParameters(this.Url, routingParameters, queryParameters);
        }

        protected void LogException(Exception ex)
        {
            if (this.Log != null)
            {
                this.Log.Error(string.Format("API client error for URL {0}", this.Url), ex);
            }
        }

        private void SetLogger()
        {
            if (ServiceLocator.IsLocationProviderSet && this.Log == null)
            {
                this.Log = ServiceLocator.Current.GetInstance<IHfeaLogger>();
             }
        }
    }
}
