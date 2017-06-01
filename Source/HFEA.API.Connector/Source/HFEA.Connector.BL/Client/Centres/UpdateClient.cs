using System;
using HFEA.Connector.Contracts.Client.Centres;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.ClinicProfile;
using HFEA.Connector.Contracts.ClinicProfile.PostUpdateModel;
using HFEA.Connector.Service.Constants;
using System.Collections.Generic;

namespace HFEA.Connector.Service.Clients.Centres
{
    public class UpdateClient : BasePostClient, ICentreUpdater
    {
        private const ApiType.Centre DetailsApi = ApiType.Centre.UpdateDetails;
        private const ApiType.Centre AddressApi = ApiType.Centre.UpdateAddress;
        private const ApiType.Centre ContactApi = ApiType.Centre.UpdateContact;
        private const ApiType.Centre LicenceApi = ApiType.Centre.UpdateLicenceProcesses;
        private const ApiType.Centre CompanyTypeApi = ApiType.Centre.UpdateClinicCompanyType;

        public UpdateClient(IPostClientFactory factory) : base(factory)
        { }

        public bool UpdateClinicDetails(Clinic clinic)
        {
            return this.Factory.GetApiClient(DetailsApi).ExecuteRequest(clinic);
        }

        public bool UpdateAddressDetails(Address address)
        {
            return this.Factory.GetApiClient(AddressApi).ExecuteRequest(address);
        }

        public bool UpdateContact(Contact contact)
        {
            return this.Factory.GetApiClient(ContactApi).ExecuteRequest(contact);
        }

        public bool UpdateLicenceProcesses(Licence licence)
        {
            return this.Factory.GetApiClient(DetailsApi).ExecuteRequest(licence);
        }

        public bool UpdateCompanyType(Contracts.ClinicProfile.PostUpdateModel.UpdateCentreInformationEntity companyType)
        {
            return this.Factory.GetApiClient(DetailsApi).ExecuteRequest(companyType);
        }

        public bool UpdateCompanyType(List<Contracts.ClinicProfile.PostUpdateModel.UpdateCentreInformationEntity> companyType, int centreId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStaff(List<Contracts.ClinicProfile.PostUpdateModel.UpdateCentreInformationEntity> staffList, int centreId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateFacilities(List<Contracts.ClinicProfile.PostUpdateModel.UpdateCentreInformationEntity> facilitiesList, int centreId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEligibilityAndFunding(List<Contracts.ClinicProfile.PostUpdateModel.UpdateCentreInformationEntity> eligibilityAndFundingList, int centreId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCentreInformation(List<Contracts.ClinicProfile.PostUpdateModel.UpdateCentreInformationEntity> centreInformationList, int centreId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOpeningHours(List<UpdateCentreInformationEntity> openingHoursList, int centreId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAddress(UpdateAddressEntity addressToUpdate, int centreId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCentreBasicContactDetails(List<ClinicBasicContactDetails> basicContactDetailsList, int centreId)
        {
            throw new NotImplementedException();
        }
    }
}
