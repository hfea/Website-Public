using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HFEA.Connector.Test.AccessControl;
using HFEA.Connector.Service.Client.Centres;
using HFEA.Connector.Contracts.Centre;
using HFEA.Connector.Contracts.Constants;

namespace HFEA.Connector.Test.ClinicTest
{
    [Ignore] // TODO
    [TestClass]
    public class ClinicProfileDataWriterTest : SDKTestBase
    {
        public const string Role_Type_PR = "";
        public const string Role_Type_LH = "";
        public const string Role_Type_RPR = "";
        public const string Role_Type_ALERT = "";
        public const string Role_Type_BillingContact = "";
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsExceptionIfNoFactoryProvided()
        {
            var client = new ClinicProfileWriter(null, this.Logger);
        }

        [TestMethod]
        public void IsCompanyTypeUpdated()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            List<EntityAdditionalInformation> types = new List<EntityAdditionalInformation>();

            types.Add(new EntityAdditionalInformation
            {
                Checked = false,
                DataType = "",
                EntityId = this.CurrentCentreId,
                LookupItemId = 0,
                LookupItemName = "",
                LookupItemParentId = 0,
                Text = ""

            });
            types.Add(new EntityAdditionalInformation
            {
                Checked = false,
                DataType = "",
                EntityId = this.CurrentCentreId,
                LookupItemId = 0,
                LookupItemName = "",
                LookupItemParentId = 0,
                Text = ""

            });
            types.Add(new EntityAdditionalInformation
            {
                Checked = false,
                DataType = "",
                EntityId = this.CurrentCentreId,
                LookupItemId = 0,
                LookupItemName = "",
                LookupItemParentId = 0,
                Text = ""

            });
            types.Add(new EntityAdditionalInformation
            {
                Checked = false,
                DataType = "",
                EntityId = this.CurrentCentreId,
                LookupItemId = 0,
                LookupItemName = "",
                LookupItemParentId = 0,
                Text = ""

            });
            types.Add(new EntityAdditionalInformation
            {
                Checked = false,
                DataType = "",
                EntityId = this.CurrentCentreId,
                LookupItemId = 0,
                LookupItemName = "",
                LookupItemParentId = 0,
                Text = ""

            });
            types.Add(new EntityAdditionalInformation
            {
                Checked = false,
                DataType = "",
                EntityId = this.CurrentCentreId,
                LookupItemId = 0,
                LookupItemName = "",
                LookupItemParentId = 0,
                Text = ""

            });
            types.Add(new EntityAdditionalInformation
            {
                Checked = false,
                DataType = "",
                EntityId = this.CurrentCentreId,
                LookupItemId = 0,
                LookupItemName = "",
                LookupItemParentId = 0,
                Text = ""

            });
            var result = client.UpdateClinicEntityType(this.CurrentCentreId, types);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CounsellingAndSupportUpdate_Success()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            List<EntityAdditionalInformation> list = new List<EntityAdditionalInformation>();
            list.Add(new EntityAdditionalInformation
            {
                Checked = false,
                DataType = "",
                EntityId = this.CurrentCentreId,
                LookupItemId = 0,
                LookupItemName = "",
                LookupItemParentId = 0,
                Text = ""

            });
            list.Add(new EntityAdditionalInformation
            {
                Checked = false,
                DataType = "",
                EntityId = this.CurrentCentreId,
                LookupItemId = 0,
                LookupItemName = "",
                LookupItemParentId = 0,
                Text = ""

            });
            list.Add(new EntityAdditionalInformation
            {
                Checked = false,
                DataType = "",
                EntityId = this.CurrentCentreId,
                LookupItemId = 0,
                LookupItemName = "",
                LookupItemParentId = 0,
                Text = ""

            });
            list.Add(new EntityAdditionalInformation
            {
                Checked = false,
                DataType = "",
                EntityId = this.CurrentCentreId,
                LookupItemId = 0,
                LookupItemName = "",
                LookupItemParentId = 0,
                Text = ""
            });

            var result = client.UpdateCounsellingAndSupport(this.CurrentCentreId, list);
            Assert.IsTrue(result.Result);

        }

        [TestMethod]
        public void IsPRContactUpdated()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            var contact = new UpdateCentreRolePersonContact
            {
                Email = "sam.smith@mailaddress.com",
                FirstName = "Sam",
                LastName = "Smith",
                EntityType = "Person",
                Phone = "01234 567 8910",
                RoleType = ""
            };
            var result = client.UpdateCentreRolePersonContact(this.CurrentCentreId, contact);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public async void BillingAddressUpdated_Succeed()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            var address = new Connector.Contracts.ClinicProfile.Address
            {
                AddressType = "",                 
            };

            var result = await client.UpdateAddress(this.CurrentCentreId, address);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsLHContactUpdated()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            var contact = new UpdateCentreRolePersonContact
            {
                Email = "sam.smith@mailaddress.com",
                FirstName = "Sammy",
                LastName = "Smithy",
                EntityType = "Centre",
                Phone = "01234 567 8910",
                RoleType = Role_Type_LH
            };
            var result = client.UpdateCentreRolePersonContact(this.CurrentCentreId, contact);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsResearchPRContactUpdated()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            var contact = new UpdateCentreRolePersonContact
            {
                Email = "research.pr@mailaddress.com",
                FirstName = "Jane",
                LastName = "Doe",
                EntityType = "Centre",
                Phone = "01234 567 8910",
                RoleType = ""
            };
            var result = client.UpdateCentreRolePersonContact(this.CurrentCentreId, contact);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPRRolePersonContactAdded()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            var contact = new InsertCentreRolePersonContact
            {
                Email = "pr@mailaddress.com",
                FirstName = "FirstName",
                LastName = "LastName",
                Phone = "01234 567 8910",
                RoleType = Role_Type_PR
            };
            bool result = client.InsertCentreRolePersonContact(this.CurrentCentreId, contact);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsLicenceHolderRolePersonContactAdded()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            var contact = new InsertCentreRolePersonContact
            {
                Email = "lh@mailaddress.com",
                FirstName = "john",
                LastName = "Smith",
                Phone = "01234 567 8910",
                RoleType = Role_Type_LH
            };
            bool result = client.InsertCentreRolePersonContact(this.CurrentCentreId, contact);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsReasearchPRRolePersonContactAdded()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            var contact = new InsertCentreRolePersonContact
            {
                Email = "rpr@mailaddress.com",
                FirstName = "John",
                LastName = "Smith",
                Phone = "01234 567 8910",
                RoleType = Role_Type_RPR
            };
            bool result = client.InsertCentreRolePersonContact(this.CurrentCentreId, contact);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsHFEAAlertAddedContactAdded()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            var contact = new InsertCentreRolePersonContact
            {
                Email = "ac@mailaddress.com",
                FirstName = "Alert",
                LastName = "Contact",
                Phone = "01234 567 8910",
                RoleType = Role_Type_ALERT
            };
            bool result = client.InsertCentreRolePersonContact(this.CurrentCentreId, contact);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsBillingContactAdded()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            var contact = new InsertCentreRolePersonContact
            {
                Email = "billingcontact1@mailaddress.com",
                FirstName = "Billing1",
                LastName = "Contact",
                Phone = "01234 567 8910",
                RoleType = Role_Type_BillingContact
            };
            bool result = client.InsertCentreRolePersonContact(this.CurrentCentreId, contact);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsHFEAAlertContactUpdated()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            var contact = new UpdateCentreRolePersonContact
            {
                Email = "alert@mailaddress.com",
                FirstName = "Alert",
                LastName = "Contact1",
                EntityType = "Person",
                Phone = "01234 567 8910",
                RoleType = Role_Type_ALERT
            };
            var result = client.UpdateCentreRolePersonContact(this.CurrentCentreId, contact);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsBillingContactUpdated()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            var contact = new UpdateCentreRolePersonContact
            {
                Email = "john.smith@mailaddress.com",
                FirstName = "Billing1",
                LastName = "Contact",
                EntityType = "Centre",
                Phone = "01234 567 8910",
                RoleType = Role_Type_BillingContact
            };
            var result = client.UpdateCentreRolePersonContact(this.CurrentCentreId, contact);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsStaffComplementByRoleInsertedOrUpdated()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);

            var list = this.GetStaffComplementByRoleObjects();

            var result = client.InsertOrUpdateStaffComplementByRole(this.CurrentCentreId, list);
            Assert.IsTrue(result.Result);
        }

        [TestMethod]
        public void IsDonorGameteWaitingTimesUpdated()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            var list = new List<InsertUpdateDonorGameteWaitingTimes>
            {
                new InsertUpdateDonorGameteWaitingTimes
                {
                  EthnicGroupLookupId = 0,
                  EggDonorWaitingTimeLookupId = 0,
                  EmbryoDonorWaitingTimeLookupId =  0,
                  SpermDonorWaitingTimeLookupId = 0
                },

                 new InsertUpdateDonorGameteWaitingTimes
                {
                  EthnicGroupLookupId = 0,
                  EggDonorWaitingTimeLookupId = 0,
                  EmbryoDonorWaitingTimeLookupId =  0,
                  SpermDonorWaitingTimeLookupId = 0
                },


                 new InsertUpdateDonorGameteWaitingTimes
                {
                  EthnicGroupLookupId = 0,
                  EggDonorWaitingTimeLookupId = 0,
                  EmbryoDonorWaitingTimeLookupId =  0,
                  SpermDonorWaitingTimeLookupId = 0
                },


                new InsertUpdateDonorGameteWaitingTimes
                {
                  EthnicGroupLookupId = 0,
                  EggDonorWaitingTimeLookupId = 0,
                  EmbryoDonorWaitingTimeLookupId =  0,
                  SpermDonorWaitingTimeLookupId = 0
                },

            };
            var result = client.InsertOrUpdateDonorGameteWaitingTimes(0, list);
            Assert.IsTrue(result.Result);
        }

        [TestMethod]
        public void UpdateEPRSSystem_Succeed()
        {
            var client = new ClinicProfileWriter(this.TokenResolver, this.Logger);
            List<EntityAdditionalInformation> list = new List<EntityAdditionalInformation>();
            list.Add(new EntityAdditionalInformation
            {
                Checked = true,
                DataType = "",
                EntityId = 0,
                LookupItemId = 0,
                LookupItemName = "",
                LookupItemParentDescription = "",
                LookupItemParentId = 0,
                Text = "",
            });
            var result = client.UpdateEPRSSystem(0, list).Result;
            Assert.IsTrue(result);
        }

        public List<EntityAdditionalInformation> GetStaffComplementByRoleObjects()
        {
            var StaffComplementByRoleList = new List<EntityAdditionalInformation>();
            int startId = 0;
            int parentId = 0;
            for (int i = startId; i <= 0; i++)
            {
                StaffComplementByRoleList.Add(new EntityAdditionalInformation
                {
                    Checked = false,
                    EntityId = 0,
                    LookupItemId = i,
                    LookupItemName = "",
                    LookupItemParentId = parentId,
                    Text = "1"
                });
            }

            return StaffComplementByRoleList;
        }
    }
}
