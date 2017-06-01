using HFEA.Connector.Contracts.ClinicProfile;
using HFEA.Connector.Contracts.ClinicProfile.PostUpdateModel;
using System.Collections.Generic;

namespace HFEA.Connector.Contracts.Client.Centres
{
    public interface ICentreUpdater
    { 
        //bool UpdateClinicDetails(Clinic clinic);

        //bool UpdateAddressDetails(Address address);

        //bool UpdateContact(Contact contact);

        //bool UpdateLicenceProcesses(Licence licence);

        bool UpdateCompanyType(List<UpdateCentreInformationEntity> companyTypeList, int centreId);
        bool UpdateStaff(List<UpdateCentreInformationEntity> staffList, int centreId);
        bool UpdateFacilities(List<UpdateCentreInformationEntity> facilitiesList, int centreId);
        bool UpdateEligibilityAndFunding(List<UpdateCentreInformationEntity> eligibilityAndFundingList, int centreId);
        bool UpdateCentreInformation(List<UpdateCentreInformationEntity> centreInformationList, int centreId);
        bool UpdateOpeningHours(List<UpdateCentreInformationEntity> openingHoursList, int centreId);
        bool UpdateAddress(UpdateAddressEntity addressToUpdate, int centreId);
        bool UpdateCentreBasicContactDetails(List<ClinicBasicContactDetails> basicContactDetailsList, int centreId);
    }
}
