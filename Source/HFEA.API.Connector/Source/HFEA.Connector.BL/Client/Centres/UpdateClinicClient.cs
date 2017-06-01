using HFEA.Connector.Contracts.Client.Centres;
using HFEA.Connector.Contracts.ClientFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.ClinicProfile;
using HFEA.Connector.Contracts.ClinicProfile.PostUpdateModel;
using System.Collections.Specialized;

namespace HFEA.Connector.Service.Client.Centres
{
    public class UpdateClinicClient  : BasePatchClient, ICentreUpdater
    {

        public UpdateClinicClient(IPatchClientFactory factory) : base(factory)
        {
        }

        public bool UpdateAddress(UpdateAddressEntity addressToUpdate, int centreId)
        {
            var parameters = new NameValueCollection();
            parameters.Add(Constants.ApiParams.Id, centreId.ToString());

            return this.Factory.GetClientApi(Constants.ApiType.Centre.UpdateAddress).ExecuteRequest<UpdateAddressEntity>(addressToUpdate, parameters, null);
            
        }

        public bool UpdateCentreBasicContactDetails(List<ClinicBasicContactDetails> basicContactDetailsList, int centreId)
        {
            var parameters = new NameValueCollection();
            parameters.Add(Constants.ApiParams.Id, centreId.ToString());
            return this.Factory.GetClientApi(Constants.ApiType.Centre.UpdateBasicClinicContacts).ExecuteRequest<ClinicBasicContactDetails>(basicContactDetailsList, parameters,null);
        }

        public bool UpdateCentreInformation(List<UpdateCentreInformationEntity> centreInformationList, int centreId)
        {
            var parameters = new NameValueCollection();
            parameters.Add(Constants.ApiParams.Id, centreId.ToString());
            return this.Factory.GetClientApi(Constants.ApiType.Centre.UpdateClinicCentreInformation).ExecuteRequest<UpdateCentreInformationEntity>(centreInformationList, parameters, null);
        }

        public bool UpdateCompanyType(List<UpdateCentreInformationEntity> companyTypeList, int centreId)
        {
            var parameters = new NameValueCollection();
            parameters.Add(Constants.ApiParams.Id, centreId.ToString());

            return this.Factory.GetClientApi(Constants.ApiType.Centre.UpdateClinicCompanyType).ExecuteRequest<UpdateCentreInformationEntity>(companyTypeList, parameters, null);
        }

        public bool UpdateEligibilityAndFunding(List<UpdateCentreInformationEntity> eligibilityAndFundingList, int centreId)
        {
            var parameters = new NameValueCollection();
            parameters.Add(Constants.ApiParams.Id, centreId.ToString());
            return this.Factory.GetClientApi(Constants.ApiType.Centre.UpdateClinicEligibilityAndFunding).ExecuteRequest<UpdateCentreInformationEntity>(eligibilityAndFundingList, parameters, null);
        }

        public bool UpdateFacilities(List<UpdateCentreInformationEntity> facilitiesList, int centreId)
        {
            var parameters = new NameValueCollection();
            parameters.Add(Constants.ApiParams.Id, centreId.ToString());

            return this.Factory.GetClientApi(Constants.ApiType.Centre.UpdateClinicFacilities).ExecuteRequest<UpdateCentreInformationEntity>(facilitiesList, parameters, null);
        }

        public bool UpdateOpeningHours(List<UpdateCentreInformationEntity> openingHoursList, int centreId)
        {
            var parameters = new NameValueCollection();
            parameters.Add(Constants.ApiParams.Id, centreId.ToString());
            return this.Factory.GetClientApi(Constants.ApiType.Centre.UpdateClinicOpeningHours).ExecuteRequest<UpdateCentreInformationEntity>(openingHoursList, parameters, null);
        }

        public bool UpdateStaff(List<UpdateCentreInformationEntity> staffList, int centreId)
        {
            var parameters = new NameValueCollection();
            parameters.Add(Constants.ApiParams.Id, centreId.ToString());

            return this.Factory.GetClientApi(Constants.ApiType.Centre.UpdateClinicStaff).ExecuteRequest<UpdateCentreInformationEntity>(staffList, parameters, null);

        }
    }
}
