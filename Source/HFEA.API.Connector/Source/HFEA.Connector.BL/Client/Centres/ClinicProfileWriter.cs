using HFEA.Connector.Contracts.Clients.Centres;
using HFEA.Connector.Global;
using HFEA.Connector.Service.BaseClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.Centre;
using HFEA.Connector.Contracts.ClinicProfile;
using Newtonsoft.Json;

namespace HFEA.Connector.Service.Client.Centres
{
    public class ClinicProfileWriter : BaseSdkClient, IClinicProfileWriter
    {
        public ClinicProfileWriter(ITokenResolver tokenResolver, IHfeaLogger logger) : base(tokenResolver, logger)
        { }

        public bool UpdateCentreRolePersonContact(int CentreId, UpdateCentreRolePersonContact RolePerconContact)
        {
            bool result = false;

            SDK.Model.UpdateCentreRolePersonContact contact = AutoMapper.Mapper.Map<SDK.Model.UpdateCentreRolePersonContact>(RolePerconContact);
            contact.EntityType = Contracts.Constants.Centre.PersonRoleContactEntityType.Person.ToString();
            contact.RoleType = ((Contracts.Constants.Centre.ContactRoleTypes)RolePerconContact.RoleTypeId).ToString();
            string output = JsonConvert.SerializeObject(contact);
            try
            {
                result = this.ApiClient.UpdateCentreRolePersonContact(CentreId.ToString(), contact);
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public bool DeactivateCentreRolePersonContact(int CentreId, DeactivateCentreRolePersonContact RolePerconContact)
        {
            bool result = false;

            SDK.Model.DeactivateCentreRolePersonContact contact = AutoMapper.Mapper.Map<SDK.Model.DeactivateCentreRolePersonContact>(RolePerconContact);
            contact.EntityType = Contracts.Constants.Centre.PersonRoleContactEntityType.Person.ToString();
            contact.RoleType = ((Contracts.Constants.Centre.ContactRoleTypes)RolePerconContact.RoleTypeId).ToString();
            contact.EndDate = DateTime.UtcNow;
            string output = JsonConvert.SerializeObject(contact);
            try
            {
                result = this.ApiClient.DeactivateCentreRolePersonContact(CentreId.ToString(), contact);
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public bool InsertCentreRolePersonContact(int CentreId, InsertCentreRolePersonContact RolePerconContact)
        {
            bool result = false;

            SDK.Model.InsertCentreRolePersonContact contact = AutoMapper.Mapper.Map<SDK.Model.InsertCentreRolePersonContact>(RolePerconContact);
            try
            {
                result = this.ApiClient.InsertCentreRolePersonContact(CentreId.ToString(), contact);

            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public bool UpdateClinicEntityType(int CentreId, List<EntityAdditionalInformation> CompanyTypes)
        {
            bool result = false;

            try
            {
                result = this.ApiClient.UpdateCompanyType(CentreId.ToString(), AutoMapper.Mapper.Map<List<SDK.Model.EntityAdditionalInformation>>(CompanyTypes));
                //result = true;
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public bool UpdateClinicStaff(int CentreId, List<EntityAdditionalInformation> StaffList)
        {
            bool result = false;

            try
            {
                result = this.ApiClient.UpdateStaff(CentreId.ToString(), AutoMapper.Mapper.Map<List<SDK.Model.EntityAdditionalInformation>>(StaffList));
                //result = true;
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public async Task<bool> UpdateEPRSSystem(int CentreId, List<EntityAdditionalInformation> EPRSSystemList)
        {
            bool result = false;

            try
            {
                result = await this.ApiClient.InsertOrUpdateEPRSSystemAsync(CentreId.ToString(), AutoMapper.Mapper.Map<List<SDK.Model.EntityAdditionalInformation>>(EPRSSystemList));
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public bool UpdateClinicFacilities(int CentreId, List<EntityAdditionalInformation> Facilities)
        {
            bool result = false;

            try
            {
                result = this.ApiClient.UpdateFacility(CentreId.ToString(), AutoMapper.Mapper.Map<List<SDK.Model.EntityAdditionalInformation>>(Facilities));
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public async Task<bool> InsertOrUpdateStaffComplementByRole(int CentreId, List<EntityAdditionalInformation> StaffComplements)
        {
            bool result = false;
            try
            {
                result = await this.ApiClient.InsertOrUpdateStaffComplimentByRoleAsync(CentreId.ToString(), AutoMapper.Mapper.Map<List<SDK.Model.EntityAdditionalInformation>>(StaffComplements));
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public async Task<bool> UpdateDonorServices(int CentreId, List<EntityAdditionalInformation> DonorServices)
        {
            bool result = false;

            try
            {
                result = await this.ApiClient.InsertOrUpdateDonorServices(CentreId.ToString(), AutoMapper.Mapper.Map<List<SDK.Model.EntityAdditionalInformation>>(DonorServices));
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;

        }

        public async Task<bool> InsertOrUpdateDonorGameteWaitingTimes(int CentreId, List<InsertUpdateDonorGameteWaitingTimes> DonorGameteWaitingTimes)
        {
            bool result = false;
            try
            {
                var sdkList = new List<SDK.Model.InsertUpdateDonorGameteWaitingTime>();

                foreach (var item in DonorGameteWaitingTimes)
                {
                    sdkList.Add(new SDK.Model.InsertUpdateDonorGameteWaitingTime
                    {
                        EthnicGroupLookupId = (SDK.Model.DonorGameteWaitingTimesEthnicGroupsEnum)item.EthnicGroupLookupId,
                        EggDonorWaitingTimeLookupId = (SDK.Model.DonorGameteWaitingTimeEnum)item.EggDonorWaitingTimeLookupId,
                        SpermDonorWaitingTimeLookupId = (SDK.Model.DonorGameteWaitingTimeEnum)item.SpermDonorWaitingTimeLookupId,
                        EmbryoDonorWaitingTimeLookupId = (SDK.Model.DonorGameteWaitingTimeEnum)item.EmbryoDonorWaitingTimeLookupId
                    });
                }
                result = await this.ApiClient.InsertUpdateDonorGameteWaitingTime(CentreId.ToString(), sdkList);
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public bool UpdateClinicEligibilityAndFunding(int CentreId, List<EntityAdditionalInformation> EligibilityAndFundingList)
        {
            bool result = false;

            try
            {
                result = this.ApiClient.UpdateEligibilityAndFunding(CentreId.ToString(), AutoMapper.Mapper.Map<List<SDK.Model.EntityAdditionalInformation>>(EligibilityAndFundingList));
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public bool UpdateLicenceProcesses(int Id, List<EntityAdditionalInformation> Treatments)
        {
            bool result = false;

            try
            {
                var list = AutoMapper.Mapper.Map<List<SDK.Model.EntityAdditionalInformation>>(Treatments);
                result = this.ApiClient.UpdateLicenseProcesses(Id.ToString(), list);
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public async Task<bool> UpdateDonorSource(int CentreId, List<EntityAdditionalInformation> donorSourceList)
        {
            bool result = false;

            try
            {
                var list = AutoMapper.Mapper.Map<List<SDK.Model.EntityAdditionalInformation>>(donorSourceList);
                result = await this.ApiClient.InsertOrUpdateDonorSourceAsync(CentreId.ToString(), list);
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public async Task<bool> UpdateOpeningHours(int CentreId, List<EntityAdditionalInformation> openingHours)
        {
            bool result = false;

            try
            {
                var list = AutoMapper.Mapper.Map<List<SDK.Model.EntityAdditionalInformation>>(openingHours);
                result = await this.ApiClient.UpdateOpeningHoursAsync(CentreId.ToString(), list);
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public async Task<bool> UpdateCounsellingAndSupport(int CentreId, List<EntityAdditionalInformation> CounsellingAndSupportList)
        {
            bool result = false;

            try
            {
                result = await this.ApiClient.InsertOrUpdateCounsellingAndSupportAsync(CentreId.ToString(), AutoMapper.Mapper.Map<List<SDK.Model.EntityAdditionalInformation>>(CounsellingAndSupportList));
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public async Task<bool> UpdateBillingPurchaseOrders(int CentreId, List<EntityAdditionalInformation> PurchaseOrders)
        {
            bool result = false;

            try
            {
                var sdkPurchaseOrders = AutoMapper.Mapper.Map<List<SDK.Model.EntityAdditionalInformation>>(PurchaseOrders);
                result = await this.ApiClient.InsertOrUpdateBillingPurchaseOrderNumberAsync(CentreId.ToString(), sdkPurchaseOrders);
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public async Task<bool> UpdateAddress(int CentreId, Contracts.ClinicProfile.Address address)
        {
            bool result = false;
            var sdkAddress = AutoMapper.Mapper.Map<SDK.Model.Address>(address);
            try
            {
                result = await ApiClient.UpdateCentreAddressAsync(CentreId.ToString(), sdkAddress);
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }


        public async Task<bool> UpdateBillingAddress(int CentreId, Contracts.ClinicProfile.Address address)
        {
            bool result = false;
            var sdkAddress = AutoMapper.Mapper.Map<SDK.Model.Address>(address);

            try
            {
                result = await ApiClient.UpdateCentreAddressAsync(CentreId.ToString(), sdkAddress);
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }

        public async Task<bool> InsertBillingAddress(int CentreId, Contracts.ClinicProfile.Address address)
        {
            bool result = false;
            var sdkAddress = AutoMapper.Mapper.Map<SDK.Model.Address>(address);

            sdkAddress.AddressType = Contracts.Constants.Centre.AddressType.Billing.ToString();
            sdkAddress.EntityType = Contracts.Constants.Centre.PersonRoleContactEntityType.Centre.ToString();

            try
            {
                result = await ApiClient.InsertCentreAddressAsync(CentreId.ToString(), sdkAddress);
            }
            catch (Exception ex)
            {
                Log.Error("", ex);
            }

            return result;
        }
    }
}
