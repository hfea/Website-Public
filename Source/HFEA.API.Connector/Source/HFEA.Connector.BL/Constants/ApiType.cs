using HFEA.Connector.Service.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Service.Constants
{
    public class ApiType
    {
        public enum BlobUpload
        {
            [CallType(HttpMethod.POST, true)]
            [Description("/api/images/upload/{id}/{imageType}")]
            UploadImage,

            [CallType(HttpMethod.POST, true)]
            [Description("/api/OLdocuments/upload2/{blobName}/{ApplicationDocumentControlID}")]
            UploadOnlineAppsFile
        }

        public enum Billing
        {
            [CallType(HttpMethod.GET, true)]
            [Description("/api/billing/absSummary?Id={id}")]
            GetBillingDetails,

            [CallType(HttpMethod.GET, true)]
            [Description("/api/billing/absImage?imageId={id}")]
            GetFile,
        }
               
        public enum Centre
        {
            [CallType(HttpMethod.GET, false)]
            [Description("/api/centres/{id}")]
            //[Description("/api/centres/mock")]
            GetCaFCCentreDetails,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/centres/{id}/successRateDetail")]
            GetClinicStatistics,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/centres/{id}/successRateOverview")]
            GetClinicStatisticsFilters,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/centres/compare?{id}")]
            GetClinicComparisonStats,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/centres/{id}/portal")]
            //[Description("/api/centres/portal/mock")]
            GetPortalCentreDetails,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/centres/{id}/portal/dashboard")]
            GetPortalDashboard,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/template/portalFeedback")]
            GetPortalFeedback,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/centres/{id}/portal/dashboard/monitoring")]
            GetPortalMonitoringDashboard,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/centres/{id}/portal/tasks/{type}")]
            GetClinicTaskListByType,

            [CallType(HttpMethod.GET, true)]
            [Description("/api/centres/{id}/users")]
            GetPortalClinicUserList,

            [CallType(HttpMethod.GET, true)]
            [Description("/api/centres/{centreId}/messages")]
            GetMessageArchive,

            [CallType(HttpMethod.GET, true)]
            [Description("/api/centres/{centreId}/messages/{messageId}")]
            GetMessage,

            [CallType(HttpMethod.POST, true)]
            [Description("/api/centres/{centreId}/users")]
            AddPortalClinicUser,

            [CallType(HttpMethod.POST, false)]
            [Description("/api/centres")]
            UpdateDetails,

            [CallType(HttpMethod.PATCH, false)]
            [Description("/api/centres/{id}/addresses")]
            UpdateAddress,

            [CallType(HttpMethod.POST, false)]
            [Description("/api/centres/contact")]
            UpdateContact,

            [CallType(HttpMethod.POST, false)]
            [Description("/api/centres/licenseprocesses")]
            UpdateLicenceProcesses,

            [CallType(HttpMethod.PATCH, false)]
            [Description("/api/centres/{id}/companytype")]
            UpdateClinicCompanyType,

            [CallType(HttpMethod.PATCH, false)]
            [Description("/api/centres/{id}/staff")]
            UpdateClinicStaff,

            [CallType(HttpMethod.PATCH, false)]
            [Description("/api/centres/{id}/facilities")]
            UpdateClinicFacilities,

            [CallType(HttpMethod.PATCH, false)]
            [Description("/api/centres/{id}/eligibilityandfunding")]
            UpdateClinicEligibilityAndFunding,

            [CallType(HttpMethod.PATCH, false)]
            [Description("/api/centres/{id}/centreinfo")]
            UpdateClinicCentreInformation,

            [CallType(HttpMethod.PATCH, false)]
            [Description("/api/centres/{id}/openinghours")]
            UpdateClinicOpeningHours,

            [CallType(HttpMethod.PATCH, false)]
            [Description("/api/centres/{id}/contact")]
            UpdateBasicClinicContacts,
        }
        public enum Search
        {
            [CallType(HttpMethod.GET, false)]
            [Description("/api/search/centres/list")]
            GetCentreList,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/search/centres/listWithProfileText")]
            GetCentreSearchList,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/search/centres")]
            GetCaFCCentreList,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/search/terms")]
            Terms,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/search/tags")]
            Tags,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/search/tags/portal")]
            ProductTagsPortal,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/search/tags/website")]
            ProductTagsWebsite,


        }
        public enum Security
        {

            [CallType(HttpMethod.GET, true)]
            [Description("/api/security/roles")]
            GetRoleList,

            // Commented out because we should not be able to create new roles from web app
            //[CallType(HttpMethod.POST, true)]
            //[Description("/api/security/roles")]
            //CreateRole,

            [CallType(HttpMethod.DELETE, true)]
            [Description("/api/security/roles/{id}")]
            DeleteRole,

            [CallType(HttpMethod.GET, true)]
            [Description("/api/security/users")]
            GetUserList,

            [CallType(HttpMethod.POST, true)]
            [Description("/api/security/users")]
            CreateUser,

            [CallType(HttpMethod.DELETE, true)]
            [Description("/api/security/users/{id}")]
            DeleteUser,

            [CallType(HttpMethod.GET, true)]
            [Description("/api/users/{id}")]
            GetUserInfo,

            [CallType(HttpMethod.GET, true)]
            [Description("/api/users/me")]
            GetMe,

            [CallType(HttpMethod.PATCH, true)]
            [Description("/api/security/users/{id}")]
            UpdateUserInfo,

            [CallType(HttpMethod.GET, true)]
            [Description("/api/security/groups")]
            GetGroupList,

            [CallType(HttpMethod.POST, true)]
            [Description("/api/security/groups")]
            CreateGroup,

            [CallType(HttpMethod.DELETE, true)]
            [Description("/api/security/groups/{id}")]
            DeleteGroup
        }

        public enum ReferenceData
        {
            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/lookupCategory")]
            GetLookupCategory,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/lookupCategoryUsage")]
            GetLookupCategoryUsage,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/documents/{id}")]
            GetDocument,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/documents/chairLetters")]
            GetChairLetters,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/documents/alerts")]
            GetAlerts,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/documents/chairLetters/{year}")]
            GetChairLettersByYear,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/documents/ceoLetters")]
            GetCeoLetters,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/documents/ceoLetters/{year}")]
            GetCeoLettersByYear,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/directions")]
            GetDirections,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/licenceConditionsResearch")]
            GetLicenceConditionsResearch,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/licenceConditionsTS")]
            GetLicenceConditionsTreatmentStorage,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/licenceconditions/{id}")]
            GetLicenceConditionItem,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/codeOfPracticeSection")]
            GetCopSection,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/codeOfPractice")]
            GetCop,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/pgdConditions")]
            GetPgdConditions,

            [CallType(HttpMethod.GET, false)]
            [Description("/api/reference/regulatoryPrinciples")]
            GetRegulatoryPrinciples
        }

        //public enum TaskTypes
        //{
        //    [CallType(HttpMethod.GET, false)]
        //    [Description("/api/TaskTypes")]
        //    TaskTypes,

        //    [CallType(HttpMethod.GET, false)]
        //    [Description("/api/centres/{id}/tasks")]
        //    ClinicTaskList
        //}

        // IR
        public enum Inspection
        {
            [CallType(HttpMethod.GET, true)]
            [Description("/api/centres/{id}/inspection")]
            TreatmentInspectionReports,

        }
        public enum RiskPerformance
        {
            //[CallType(HttpMethod.GET, true)]
            //[Description("/api/performance/charts/months/{id}")]
            //PerformanceChartsMonths,

            //[CallType(HttpMethod.GET, true)]
            //[Description("/api/performance/centres/{id}?year=x&month=y")]
            //PerformanceData,

            [CallType(HttpMethod.GET, true)]
            [Description("/api/performance/centres/gpi")]
            GPIPerformanceData,

            [CallType(HttpMethod.GET, true)]
            [Description("/api/performance/charts/{id}")]
            GPIPerformanceDataChart,

            [CallType(HttpMethod.GET, true)]
            [Description("/api/performance/centres/kri")]
            KRIPerformanceData,

            [CallType(HttpMethod.GET, true)]
            [Description("/api/performance/centres/{id}/kri/detail")]
            KRIPerformanceDataDetails
        }
        public enum CaFCFeedback
        {
            [CallType(HttpMethod.GET, false)]
            [Description("/api/template/patientFeedback")]
            LoadCaFCFeedback,

            [CallType(HttpMethod.POST, true)]
            [Description("/api/feedback/patientFeedback")]
            PostCaFCFeedback
        }
    }
}
