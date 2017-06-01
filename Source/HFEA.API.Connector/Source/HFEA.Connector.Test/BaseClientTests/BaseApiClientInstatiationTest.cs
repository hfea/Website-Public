using HFEA.Connector.Service.BaseClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Specialized;

namespace HFEA.Connector.Test.BaseClientTests
{
    [TestClass]
    public class BaseApiClientInstatiationTest
    {
        internal class ConcreteApiClient : BaseApiClient
        {
            public ConcreteApiClient(string url) : base(url) { }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ApiClientThrowsNullExceptionIfNoUrlProvided()
        {
            var client = new ConcreteApiClient(string.Empty);
        }
        
        [TestMethod]
        
        public void ApiClientInstantiatedSuccessfully()
        {
            var client = new ConcreteApiClient("api/valid-url");
            Assert.IsNotNull(client);
        }
    }
}
