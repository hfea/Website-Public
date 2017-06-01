using HFEA.Connector.Contracts.BlobUpload;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Client
{
    public interface IApiPostClient
    {
        bool ExecuteRequest<T>(T postObject) where T : new();

        bool ExecuteRequest<T>(T postObject, NameValueCollection routingParameters, NameValueCollection queryParameters) where T : new();

        bool UploadData(byte[] fileData, string filename, NameValueCollection routingParameters, NameValueCollection queryParameters);

        bool UploadData(byte[] fileData, string filename, string contentType, NameValueCollection routingParameters, NameValueCollection queryParameters);

        bool UploadData<T>(byte[] fileData, string filename, string contentType, NameValueCollection routingParameters, NameValueCollection queryParameters, out T file) where T : class, new();
    }
}
