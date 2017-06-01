using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Service.BaseClient;
using HFEA.Connector.Service.Client.Centres;
using HFEA.Connector.Service.Client.Various;
using HFEA.Connector.Service.Extensions;
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
    public class CentreImageUpdateTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsNullExceptionIfNoFactoryProvided()
        {
            var client = new BlobUploadClient(null);
        }

        [TestMethod]
        [Ignore]
        public void ClinicProfileImageIsSaved()
        {
            // TODO: This is not an extremely valuable test as it tests API rather than our application
            // updates to come           
            var api = Service.Constants.ApiType.BlobUpload.UploadImage;

            Mock<IPostClientFactory> factoryMock = new Mock<IPostClientFactory>();
            factoryMock.Setup(x => x.GetApiClient(api)).Returns(new PostClient(api.GetDescription(), string.Empty));

            var client = new BlobUploadClient(factoryMock.Object);

            byte[] file = UTF8Encoding.UTF8.GetBytes("my test data");
            int centreId = 4;

            bool result = client.UpdateImage(centreId, "image/jpeg", file);

            Assert.IsTrue(result);
        }

        [TestInitialize]
        public void Init()
        {
            IocInit.Init();
        }
    }
}
