using HFEA.Connector.Service.ClientFactories;
using HFEA.Connector.Service.Clients.AccessControl;
using HFEA.Connector.Service.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace HFEA.Connector.Test.AccessControl
{
    [TestClass]
    public class AccessControlReaderTest : SDKTestBase
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsExceptionIfNoFactoryProvided()
        {
            var client = new ClinicUserReader(null, this.Logger);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetClientListMethodThrowsOutOfRangeExceptionIfClinicIdLessThanOne()
        {
            var client = new ClinicUserReader(this.TokenResolver, this.Logger);
            client.GetClinicUserList(0);
        }

        [TestMethod]
        [Ignore]
        public void FullListListOfUsersNotEmpty()
        {
            var client = new ClinicUserReader(this.TokenResolver, this.Logger);
            var results = client.GetClinicUserList(this.CurrentCentreId);

            Assert.IsNotNull(results);
            Assert.IsTrue(results.Any());
        }
    }
}
