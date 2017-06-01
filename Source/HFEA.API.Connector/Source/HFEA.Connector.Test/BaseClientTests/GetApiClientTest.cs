using HFEA.Connector.Contracts.Users;
using HFEA.Connector.Service.BaseClient;
using HFEA.Connector.Service.Constants;
using Microsoft.Practices.ServiceLocation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Test.BaseClientTests
{
    [TestClass]
    public class GetApiClientTest
    {
        private const string Url404 = "/api/404";
        private const string UrlSecured = "/api/users/0";
        private const string Token = "valid security token";

        [TestMethod]
        public void GetApiClientInheritsBaseApiClient()
        {
            // if this test would ever fail then secured api client's constructor must be additionally tested
            // for validity of input parameters
            var client = new GetClient("/any-url", "any-token");
            Assert.IsInstanceOfType(client, typeof(BaseApiClient));
        }

        [TestMethod]
        public void ExecuteRequestThrows401ExceptionIfSecurityTokenNullOrEmpty()
        {
            HttpRequestException e = null;
            try
            {
                var client = new GetClient(UrlSecured, string.Empty);
                client.ExecuteRequest<User>();
            }
            catch (HttpRequestException ex)
            {
                e = ex;
            }

            Assert.IsNotNull(e);
            Assert.IsTrue(e.Message.Contains("401"));
        }

        [TestMethod]
        public void ExecuteRequestThrows404ExceptionIfUrlNotValid()
        {
            HttpRequestException e = null;

            try
            {
                var client = new GetClient(Url404, string.Empty);
                var user = new User();

                client.ExecuteRequest<User>();
            }
            catch (HttpRequestException ex)
            {
                e = ex;
            }

            Assert.IsNotNull(e);
            Assert.IsTrue(e.Message.Contains("404"));
        }

        [TestInitialize]
        public void Init()
        {
            IocInit.Init();
        }
    }
}
