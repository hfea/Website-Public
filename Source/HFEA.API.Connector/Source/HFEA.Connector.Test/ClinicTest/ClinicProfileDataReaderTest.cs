using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HFEA.Connector.Test.AccessControl;
using HFEA.Connector.Service.Client.Centres;

namespace HFEA.Connector.Test.ClinicTest
{
    // [TestClass]
    // This is an irrelevant test class. We don't use SDK to get clinic data
    public class ClinicProfileDataReaderTest : SDKTestBase
    {
        //[TestMethod]
        //[ExpectedException(typeof(ArgumentNullException))]
        //public void ConstructorThrowsExceptionIfNoFactoryProvided()
        //{
        //    var client = new ClinicProfileReader(null);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void GetClinicProfileDataMethodThrowsOutOfRangeExceptionIfClinicIdLessThanOne()
        //{
        //    var client = new ClinicProfileReader(this.TokenResolver);
        //    var res = client.GetCentrePortalData(0);
        //}

        //[TestMethod]
        //[Ignore] // TODO
        //public void CentrePortalDataIsNotNull()
        //{
        //    var client = new ClinicProfileReader(this.TokenResolver);
        //    var result = client.GetCentrePortalData(this.CurrentCentreId);

        //    Assert.IsNotNull(result);
        //}
    }
}
