using HFEA.Connector.Contracts.Users;
using HFEA.Connector.Service.BaseClient;
using HFEA.Connector.Service.Constants;
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
    public class PostApiClientTest
    {
        private const string Token = "invalid security token";

        [TestInitialize]
        public void Init()
        {
            IocInit.Init();
        }

        [TestMethod]
        public void SecuredPostApiClientInheritsBaseApiClient()
        {            
            // if this test would ever fail then secured api client's constructor must be additionally tested
            // for validity of input parameters
            var client = new GetClient("/any-url", "any token");
            Assert.IsInstanceOfType(client, typeof(BaseApiClient));
        }
    }
}
