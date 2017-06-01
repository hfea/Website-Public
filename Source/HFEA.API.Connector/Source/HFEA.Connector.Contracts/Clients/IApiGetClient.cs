using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Client
{
    public interface IApiGetClient
    {
        T ExecuteRequest<T>() where T : new();

        T ExecuteRequest<T>(NameValueCollection routingParameters, NameValueCollection queryParameters) where T : new();

        string ExecuteRequestGetJson(NameValueCollection routingParameters, NameValueCollection queryParameters);
        object ExecuteRequest<T>(object p, string clinicId);
    }
}
