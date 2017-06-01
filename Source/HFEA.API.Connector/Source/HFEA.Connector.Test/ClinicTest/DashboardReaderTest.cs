using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HFEA.Connector.Test.AccessControl;
using HFEA.Connector.Service.Constants;
using HFEA.Connector.Service.Client.Centres;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Client;
using Moq;
using HFEA.Connector.Contracts.CentreDashboard;

namespace HFEA.Connector.Test.ClinicTest
{
    [TestClass]
    public class DashboardReaderTest
    {
        private const ApiType.Centre DashboardData = ApiType.Centre.GetPortalDashboard;
        IGetSecuredClientFactory clientFactory;

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsExceptionIfNoFactoryProvided()
        {
            var client = new CentreDashboardClient(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowExceptionIfCentreIdIsLessThanOrEqualsZero()
        {
            var client = new CentreDashboardClient(this.clientFactory);
            var dashboard = client.GetCentreDashboard(0);
        }

        [TestMethod]
        public void DataRead_Succeed()
        {
            var client = new CentreDashboardClient(this.clientFactory);
            var data = client.GetCentreDashboard(0);
        }

        [TestInitialize]
        public void Init()
        {        
            Mock<IApiGetClient> mockClient = new Mock<IApiGetClient>();            

            Mock<IGetSecuredClientFactory> mockFactory = new Mock<IGetSecuredClientFactory>();
            mockFactory.Setup(x => x.GetApiClient(ApiType.Centre.GetPortalDashboard)).Returns(mockClient.Object);
            this.clientFactory = mockFactory.Object;
        }

    }
}
