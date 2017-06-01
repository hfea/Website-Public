using HFEA.Connector.Contracts.Client;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HFEA.Connector.Service.BaseClient
{
    internal class GetClient : BaseApiClient, IApiGetClient
    {
        private string token;

        public GetClient(string url, string authToken) : base(url)
        {
            token = authToken ?? string.Empty;
        }

        public T ExecuteRequest<T>() where T : new()
        {
            return this.ExecuteRequest<T>(null, null);
        }

        public object ExecuteRequest<T>(object p, string clinicId)
        {
            throw new NotImplementedException();
        }

        public T ExecuteRequest<T>(NameValueCollection routingParameters, NameValueCollection queryParameters) where T : new()
        {
            Func<HttpResponseMessage, Task<T>> readerDelegate = (x) => { return x.Content.ReadAsAsync<T>(); };

            return this.Execute(routingParameters, queryParameters, readerDelegate);
        }

        public string ExecuteRequestGetJson(NameValueCollection routingParameters, NameValueCollection queryParameters)
        {
            Func<HttpResponseMessage, Task<string>> readerDelegate = (x) => { return x.Content.ReadAsStringAsync(); };

            return this.Execute(routingParameters, queryParameters, readerDelegate);
        }

        private T Execute<T>(NameValueCollection routingParameters, NameValueCollection queryParameters, Func<HttpResponseMessage, Task<T>> reader)
        {
            // if (string.IsNullOrEmpty(token)) throw new ArgumentNullException("Secured token has not been provided");

            T result = default(T);
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();

                if (!string.IsNullOrEmpty(this.token))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(BearerHeaderString, token);
                }

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(JsonHeaderString));
                string url = this.GetUrlWithParameters(routingParameters, queryParameters);

                try
                {
                    using (HttpResponseMessage response = client.GetAsync(url).Result)
                    {
                        response.EnsureSuccessStatusCode();                   

                        var content = reader(response);                   

                        result = content.Result;
                    }
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
