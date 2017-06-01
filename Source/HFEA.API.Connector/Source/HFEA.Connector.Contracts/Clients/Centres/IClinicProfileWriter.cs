using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.Centre;
using HFEA.Connector.Contracts.ClinicProfile;

namespace HFEA.Connector.Contracts.Clients.Centres
{
    public interface IClinicProfileWriter
    {       
        bool UpdateClinicEntityType(int CentreId,List<EntityAdditionalInformation> CompanyTypes);
        bool UpdateClinicStaff(int CentreId, List<EntityAdditionalInformation> StaffList);
        bool UpdateClinicFacilities(int CentreId, List<EntityAdditionalInformation> Facilities);
        bool UpdateClinicEligibilityAndFunding(int CentreId, List<EntityAdditionalInformation> EligibilityAndFundingList);
        Task<bool> UpdateEPRSSystem(int CentreId, List<EntityAdditionalInformation> EPRSSystemList);
        bool UpdateLicenceProcesses(int Id, List<EntityAdditionalInformation> Treatments);
        bool UpdateCentreRolePersonContact(int CentreId, UpdateCentreRolePersonContact RolePerconContact);
        bool InsertCentreRolePersonContact(int CentreId, InsertCentreRolePersonContact RolePerconContact);
        Task<bool> InsertOrUpdateStaffComplementByRole(int CentreId, List<EntityAdditionalInformation> StaffComplements);
        Task<bool> InsertOrUpdateDonorGameteWaitingTimes(int CentreId, List<InsertUpdateDonorGameteWaitingTimes> DonorGameteWaitingTimes);
        Task<bool> UpdateDonorServices(int CentreId, List<EntityAdditionalInformation> DonorServices);
        Task<bool> UpdateOpeningHours(int CentreId, List<EntityAdditionalInformation> openingHours);
        Task<bool> UpdateCounsellingAndSupport(int CentreId, List<EntityAdditionalInformation> CounsellingAndSupportList);
        Task<bool> UpdateDonorSource(int CentreId, List<EntityAdditionalInformation> donorSourceList);
        Task<bool> UpdateAddress(int CentreId, ClinicProfile.Address address);
        Task<bool> UpdateBillingAddress(int CentreId, ClinicProfile.Address address);
        Task<bool> UpdateBillingPurchaseOrders(int CentreId, List<EntityAdditionalInformation> PurchaseOrders);
        bool DeactivateCentreRolePersonContact(int CentreId, DeactivateCentreRolePersonContact RolePerconContact);
        Task<bool> InsertBillingAddress(int centreId, ClinicProfile.Address addressToUpdate);
    }
}
