using HFEA.Connector.Contracts.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net.Http;
using System.Net.Http.Headers;
using HFEA.Connector.Service.Extensions;
using Newtonsoft.Json;

namespace HFEA.Connector.Service.BaseClient
{
    internal class PatchClient : BaseApiClient, IApiPatchClient
    {
        private readonly string token;
        public PatchClient(string url, string securityToken) : base(url)
        {
            this.token = securityToken ?? string.Empty;
        }

        public bool ExecuteRequest<T>(T patchObject) where T : new()
        {
            return this.ExecuteRequest<T>(patchObject, null, null);
        }

        public bool ExecuteRequest<T>(List<T> patchObject) where T : new()
        {
            return this.ExecuteRequest<T>(patchObject, null, null);
        }

        public bool ExecuteRequest<T>(T patchObject, NameValueCollection routingParameters, NameValueCollection queryParameters) where T : new()
        {
            Func<HttpClient, string, HttpResponseMessage> executeClientDelegate = (client, url) =>
            {
                Type t = typeof(T);
                return client.PatchJsonAsync(url, t, patchObject).Result;
            };

            return this.Execute(executeClientDelegate, routingParameters, queryParameters);
        }

        public bool ExecuteRequest<T>(List<T> patchObject, NameValueCollection routingParameters, NameValueCollection queryParameters) where T : new()
        {
            Func<HttpClient, string, HttpResponseMessage> executeClientDelegate = (client, url) =>
            {
                Type t = typeof(List<T>);
                return client.PatchJsonAsync(url, t, patchObject).Result;
            };

            return this.Execute(executeClientDelegate, routingParameters, queryParameters);
        }

        private bool Execute(Func<HttpClient, string, HttpResponseMessage> executeClientDelegate, NameValueCollection routingParameters, NameValueCollection queryParameters)
        {
            //if (string.IsNullOrEmpty(token)) throw new ArgumentNullException("Secured token has not been provided");

            bool result = false;
            using (var client = new HttpClient())
            {
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
                    string str = response.Content.ReadAsStringAsync().Result;
                    response.EnsureSuccessStatusCode();

                    result = true;
                }
                //TODO:
                //exception handling
                //     Catch authentication exception and handle it separately.Token renewal might be required
                //    catch (HttpRequestException ex)
                //{
                //    throw ex;
                //}
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
