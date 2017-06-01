using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Service.ClientFactories;
using HFEA.Connector.Service.Clients.CaFC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HFEA.Connector.Test
{
    [TestClass]
    public class CaFCProfileApiClientTest
    {   
        ProfileClient client;

        [TestMethod]
        [Ignore()] // this test fails because security token is not provided
        public void BaseClientExecuted()
        {
            Assert.IsNotNull(this.client);

            var results = client.GetClinicProfile(0);

            Assert.IsNotNull(results);
            Assert.IsInstanceOfType(results, typeof(ClinicProfile));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsExceptionIfNoApiClient()
        {
            var client = new ProfileClient(null);
        }
        
        [TestInitialize]
        public void Init()
        {
            IocInit.Init();
            var factory = new ApiGetClientFactory(string.Empty);
            this.client = new ProfileClient(factory);
        }
    }
}
