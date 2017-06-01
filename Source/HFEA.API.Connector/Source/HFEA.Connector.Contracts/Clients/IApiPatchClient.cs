using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients
{
    public interface IApiPatchClient
    {
        bool ExecuteRequest<T>(List<T> patchObject) where T : new();

        bool ExecuteRequest<T>(List<T> patchObject, NameValueCollection routingParameters, NameValueCollection queryParameters) where T : new();

        bool ExecuteRequest<T>(T patchObject) where T : new();
        bool ExecuteRequest<T>(T patchObject, NameValueCollection routingParameters, NameValueCollection queryParameters) where T : new();

    }
}
