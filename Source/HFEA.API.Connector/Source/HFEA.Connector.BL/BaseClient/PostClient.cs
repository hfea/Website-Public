using HFEA.Connector.Contracts.BlobUpload;
using HFEA.Connector.Contracts.Client;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HFEA.Connector.Service.BaseClient
{
    internal class PostClient : BaseApiClient, IApiPostClient
    {
        private readonly string token;

        public PostClient(string url, string securityToken) : base(url)
        {
            this.token = securityToken ?? string.Empty;

        }

        public bool ExecuteRequest<T>(T postObject) where T : new()
        {
            return this.ExecuteRequest<T>(postObject, null, null);
        }

        public bool ExecuteRequest<T>(T postObject, NameValueCollection routingParameters, NameValueCollection queryParameters) where T : new()
        {
            Func<HttpClient, string, HttpResponseMessage> executeClientDelegate = (client, url) =>
            {
                return client.PostAsJsonAsync<T>(url, postObject).Result;
            };

            return this.Execute(executeClientDelegate, routingParameters, queryParameters);
        }

        public bool UploadData(byte[] fileData, string filename, NameValueCollection routingParameters, NameValueCollection queryParameters) 
        {
            return this.UploadData(fileData, filename, null, routingParameters, queryParameters);
        }

        public bool UploadData(byte[] fileData, string filename, string contentType, NameValueCollection routingParameters, NameValueCollection queryParameters)
        {            
            List<BlobFileInfo> file;
            return this.UploadData(fileData, filename, contentType, routingParameters, queryParameters, out file);
        }

        public bool UploadData<T>(byte[] fileData, string filename, string contentType, NameValueCollection routingParameters, NameValueCollection queryParameters, out T blobFile)
            where T : class, new()
        {
            Func<HttpClient, string, HttpResponseMessage> executeClientDelegate = (client, url) =>
            {
                using (var content = new MultipartFormDataContent())
                {
                    var fileContent = new ByteArrayContent(fileData);

                    string contentTypeToPass = !string.IsNullOrEmpty(contentType) ? contentType : "application/octet-stream";
                    fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(contentTypeToPass);
                    content.Add(fileContent, "file", filename);

                    HttpResponseMessage response = client.PostAsync(url, content).Result;
                   
                    return response;
                }
            };

            return this.Execute(executeClientDelegate, routingParameters, queryParameters, out blobFile);
        }

        private bool Execute<T>(Func<HttpClient, string, HttpResponseMessage> executeClientDelegate, NameValueCollection routingParameters, NameValueCollection queryParameters, out T responseData)
            where T : class, new()            
        {
            bool result = false;
            using (var client = new HttpClient())
            {
                //ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;


                client.DefaultRequestHeaders.Accept.Clear();

                if (!string.IsNullOrEmpty(this.token))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(BearerHeaderString, token);
                }
                
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(JsonHeaderString));

                try
                {
                    string url = this.GetUrlWithParameters(routingParameters, queryParameters);
                    HttpResponseMessage response = executeClientDelegate(client, url);
                    response.EnsureSuccessStatusCode();
                    result = true;

                    responseData = response.Content.ReadAsAsync<T>().Result;

                    response.Dispose();                    
                }

                catch (HttpRequestException httpEx)
                {
                    this.LogException(httpEx);
                    throw;
                }
                catch (Exception ex)
                {
                    this.LogException(ex);
                    throw;
                }
            }

            return result;
        }

        private bool Execute(Func<HttpClient, string, HttpResponseMessage> executeClientDelegate, NameValueCollection routingParameters, NameValueCollection queryParameters)
        {
            bool result = false;
            using (var client = new HttpClient())
            {
                //ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;


                client.DefaultRequestHeaders.Accept.Clear();

                if (!string.IsNullOrEmpty(this.token))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(BearerHeaderString, token);
                }

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(JsonHeaderString));

                try
                {
                    string url = this.GetUrlWithParameters(routingParameters, queryParameters);
                    HttpResponseMessage response = executeClientDelegate(client, url);
                    response.EnsureSuccessStatusCode();
                    result = true;
                    response.Dispose();
                }

                catch (HttpRequestException httpEx)
                {
                    this.LogException(httpEx);
                    throw;
                }
                catch (Exception ex)
                {
                    this.LogException(ex);
                    throw;
                }
            }

            return result;
        }
    }
}
