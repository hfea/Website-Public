using HFEA.Connector.Contracts.Client;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Service.Client.Centres;
using HFEA.Connector.Service.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Test.ClinicTest
{
    [TestClass]
    public class BillingDetailsReaderTest
    {
        IGetSecuredClientFactory clientFactory;

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsExceptionIfNoFactoryProvided()
        {
            var client = new BillingDetailsReaderClient(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowExceptionIfCentreIdIsLessThanOrEqualsZero()
        {
            var client = new BillingDetailsReaderClient(this.clientFactory);
            var data = client.GetBillingData(0);
        }

        [TestInitialize]
        public void Init()
        {
            Mock<IApiGetClient> mockClient = new Mock<IApiGetClient>();

            Mock<IGetSecuredClientFactory> mockFactory = new Mock<IGetSecuredClientFactory>();
            mockFactory.Setup(x => x.GetApiClient(ApiType.Billing.GetBillingDetails)).Returns(mockClient.Object);
            this.clientFactory = mockFactory.Object;
        }
    }
}
