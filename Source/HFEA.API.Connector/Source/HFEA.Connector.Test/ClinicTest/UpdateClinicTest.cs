using HFEA.Connector.Contracts.Client;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.ClinicProfile;
using HFEA.Connector.Service.Clients;
using HFEA.Connector.Service.Clients.Centres;
using HFEA.Connector.Service.ClientFactories;
using HFEA.Connector.Service.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using HFEA.Connector.Service.Client.Centres;
using HFEA.Connector.Service.BaseClient;
using HFEA.Connector.Service.Extensions;
using HFEA.Connector.Contracts.ClinicProfile.PostUpdateModel;
using System.Collections.Generic;

namespace HFEA.Connector.Test
{
    [TestClass]
    public class UpdateClinicTest
    {
        private const ApiType.Centre DetailsApi = ApiType.Centre.UpdateDetails;


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsExceptionIfNoFactoryProvided()
        {
            var client = new UpdateClinicClient(null);
        }

        [Ignore] // TODO
        [TestMethod]
        public void UpdateClinicCompanyTypeTest()
        {
            var api = ApiType.Centre.UpdateClinicCompanyType;
            Mock<IPatchClientFactory> factoryMock = new Mock<IPatchClientFactory>();
            factoryMock.Setup(x => x.GetClientApi(api)).Returns(new PatchClient(api.GetDescription(), string.Empty));

            var client = new UpdateClinicClient(factoryMock.Object);

            int centreId = 0;

            var data = this.GetCenterInformationList();

            bool result = client.UpdateCompanyType(data, centreId);
        }

        private List<UpdateCentreInformationEntity> GetCenterInformationList()
        {
            List<UpdateCentreInformationEntity> list = new List<UpdateCentreInformationEntity>();
            list.Add(
                new UpdateCentreInformationEntity
                {
                    Checked = true,
                    ControlType = "checkbox",
                    EntityId = 0,
                    FileUrl = "",
                    LookupItemId = "0",
                    LookupItemName = "",
                    LookupItemParentId = "",
                    Text = ""
                });

            list.Add(
                new UpdateCentreInformationEntity
                {
                    Checked = false,
                    ControlType = "",
                    EntityId = 0,
                    FileUrl = "",
                    LookupItemId = "",
                    LookupItemName = "",
                    LookupItemParentId = "",
                    Text = ""
                });

            list.Add(
                new UpdateCentreInformationEntity
                {
                    Checked = false,
                    ControlType = "",
                    EntityId = 0,
                    FileUrl = "",
                    LookupItemId = "",
                    LookupItemName = "",
                    LookupItemParentId = "",
                    Text = ""
                });

            list.Add(
                new UpdateCentreInformationEntity
                {
                    Checked = false,
                    ControlType = "",
                    EntityId = 0,
                    FileUrl = "",
                    LookupItemId = "",
                    LookupItemName = "",
                    LookupItemParentId = "",
                    Text = ""
                });

            list.Add(
                new UpdateCentreInformationEntity
                {
                    Checked = false,
                    ControlType = "",
                    EntityId = 0,
                    FileUrl = "",
                    LookupItemId = "",
                    LookupItemName = "",
                    LookupItemParentId = "",
                    Text = ""
                });

            list.Add(
                new UpdateCentreInformationEntity
                {
                    Checked = false,
                    ControlType = "",
                    EntityId = 0,
                    FileUrl = "",
                    LookupItemId = "",
                    LookupItemName = "",
                    LookupItemParentId = "",
                    Text = ""
                });

            list.Add(
               new UpdateCentreInformationEntity
               {
                   Checked = false,
                   ControlType = "",
                   EntityId = 0,
                   FileUrl = "",
                   LookupItemId = "",
                   LookupItemName = "",
                   LookupItemParentId = "",
                   Text = ""
               });

            return list;
        }
    }
}
