using HFEA.Connector.Contracts.Client;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Service.Attributes;
using HFEA.Connector.Service.Constants;
using HFEA.Connector.Service.Extensions;
using System;

namespace HFEA.Connector.Service.ClientFactories
{
    public class BaseClientFactory
    {
        HttpMethod clientHttpMethod;

        public BaseClientFactory(HttpMethod httpMethod)
        {
            this.clientHttpMethod = httpMethod;
        }

        /// <summary>
        /// This method pre-validates input data and throws an exception if data is not consitent 
        /// </summary>
        protected bool ValidateCallType(Enum apiType, out CallType callType)
        {
            callType = apiType.GetCallType();
            HttpMethod httpMethod = HttpMethod.Unknown;
            bool requiresAuthorization = false;

            if (callType != null)
            {
                httpMethod = callType.Method;
                requiresAuthorization = callType.RequiresAuthentication;
            }

            if (httpMethod == HttpMethod.Unknown) throw new ArgumentNullException("HTTP Method not set");
            if (httpMethod != this.clientHttpMethod) throw new ArgumentOutOfRangeException(
                string.Format("Cannot resolve client. Required HTTP method is {0} while factory resolves to {1}", 
                clientHttpMethod.ToString(),
                httpMethod.ToString()));
           //// if (this.isSecured && !requiresAuthorization) throw new ArgumentOutOfRangeException("API requires authorization");

            return true;
        }

        /// <summary>
        /// This method throws ArgumentNullException if URL cannot be resolved
        /// </summary>
        protected string GetUrl(Enum apiType)
        {
            string url = apiType.GetDescription();
            if (string.IsNullOrEmpty(url)) throw new ArgumentNullException("API URL not set");

            return url;
        }
    }
}
