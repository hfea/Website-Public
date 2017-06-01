using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HFEA.Connector.Service;
using HFEA.Connector.Service.Constants;
using HFEA.Connector.Service.Clients;

using HFEA.Connector.Service.Extensions;
using HFEA.Connector.Contracts.Client;
using HFEA.Connector.Service.BaseClient;
using HFEA.Connector.Service.ClientFactories;
using HFEA.Connector.Contracts.ClientFactories;

namespace HFEA.Connector.Test
{
    [TestClass]
    public class ApiFactoryTest
    {
        private enum WrongApiTypeEnum { Accounts, Clinics }

        private IGetClientFactory getFactory;
        private IPostClientFactory postFactory;

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FactoryThrowsNullExceptionsIfCannotResolve()
        {
            var client = getFactory.GetApiClient(WrongApiTypeEnum.Accounts);

            Assert.IsNull(client);
        }

        [TestMethod]  
        public void IsGetApiResolved()
        {
            var client = getFactory.GetApiClient(ApiType.Security.GetRoleList);

            Assert.IsNotNull(client);
            Assert.IsInstanceOfType(client, typeof(IApiGetClient));
            Assert.IsInstanceOfType(client, typeof(GetClient));
        }

        [TestMethod]
        public void IsPOSTApiResolved()
        {
            var client = postFactory.GetApiClient(ApiType.Security.CreateUser);
            Assert.IsNotNull(client);
            Assert.IsInstanceOfType(client, typeof(IApiPostClient));
            Assert.IsInstanceOfType(client, typeof(PostClient));
        }

        [TestInitialize]
        public void Setup()
        {
            getFactory = new ApiGetClientFactory("");
            postFactory = new ApiPostClientFactory("");
        }
    }
}
