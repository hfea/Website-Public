using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Constants
{
    public class Centre
    {
        private static Dictionary<ContactGroup, List<ContactType>> contactGroupDictionary;

        public enum ContactGroup
        {
            Unknown = 0,
            Centre,
            EDI,
            EDIIT,
            Website,
            Fax,
            Billing,
            AccreditedConsultant,
            OtherCentre,
            HFEAAlertConsultant,
            PR,
            LicenceHolder,
            PRResearch,
            MIsclellaneous
        }

        public enum ContactType
        {
            Unknown = 0,
            CentreEmail,
            CentrePhone,
            EdiITContactPhone,
            EdiITContactEmail
        }

        public enum RagPriority
        {
            [Description("None")]
            None = 0,
            [Description("Green")]
            Green,
            [Description("Yellow")]
            Yellow,
            [Description("Amber")]
            Amber,
            [Description("Red")]
            Red

        }

        public enum UserFeedbackScore
        {
            [Description("None")]
            None = 0,
            [Description("Very dissatisfied")]
            VeryDissatisfied = 1,
            [Description("Dissatisfied")]
            Dissatisfied = 2,
            [Description("Neither satisfied or dissatisfied")]
            NeitherSatisfiedOrDissatisfied = 3,
            [Description("Satisfied")]
            Satisfied = 4,
            [Description("Very satisfied")]
            VerySatisfied = 5
        }

        public enum ImportanceOfTask
        {
            Unknown = 0,
            Low = 1,
            Medium = 2,
            High = 3
        }

        public enum MonitoringItemType
        {
            [Description("None")]
            None = 0,
            [Description("Post inspection")]
            PostInspection,
            [Description("Post committee")]
            PostCommittee,
            [Description("Management review")]
            ManagementReview,
            [Description("RBAT Monitoring")]
            RbatMonitoring,
            [Description("Licence matters")]
            LicenceMatters,
            [Description("Executive Requests")]
            ExecutiveRequests,
        }

        public enum ContactRoleTypes
        {
            [Description("Unknown")]
            Unknown = 0,
            [Description("Person responsible")]
            PersonResponsible,
            [Description("Person responsible (research)")]
            PersonResponsibleResearch,
            [Description("Licence holder")]
            LicenceHolder,
            [Description("HFEA Alert contact")]
            HFEAAlertContact,
            [Description("HFEA Billing contact")]
            HFEABillingContact
        }

        public enum OpeningHours
        {
            Umknown = 0,
            MondayOpen,
            TuesdayOpen,
            WednesdayOpen,
            ThursdayOpen,
            FridayOpen,
            SaturdayOpen,
            SundayOpen,
            MondayClosed,
            TuesdayClosed,
            WednesdayClosed,
            ThursdayClosed,
            FridayClosed,
            SaturdayClosed,
            SundayClosed
        }

        public enum DonorSource
        {
            [Description("UK")]
            UK = 0,
            [Description("Imported")]
            Imported
        }

        public enum DonorAvailability
        {
            [Description("No data available")]
            NoDataAvailable = 0,
            [Description("Immediately available")]
            ImmediatelyAvailable,
            [Description("Less than 1 month")]
            LessThanOneMonth,
            [Description("1 - 6 months")]
            OneToSixMonths,
            [Description("More than 6 months")]
            MoreThanSixMonths
        }

        public enum EntityInfoParentId
        {
            OpeningHours = 0,
            DonorSource
        }
        public enum OtherLookupItems
        {
            [Description("Opening hours supplementary information")]
            OpeningHoursSupplementaryInformation =0,
            [Description("Purchase order number")]
            PurchaseOrderNumber
        }

        public static Dictionary<ContactGroup, List<ContactType>> ContactGroupDictionary
        {
            get
            {
                if (contactGroupDictionary == null)
                {
                    contactGroupDictionary = new Dictionary<ContactGroup, List<ContactType>>()
                    {
                        { ContactGroup.Centre, new List<ContactType>() { ContactType.CentreEmail, ContactType.CentrePhone }},
                        { ContactGroup.EDIIT, new List<ContactType>() { ContactType.EdiITContactEmail, ContactType.EdiITContactPhone }}
                    };
                }

                return contactGroupDictionary;
            }
        }

        public enum AddressType
        {
            Main = 0,
            Billing
        }

        public enum PersonRoleContactEntityType
        {
            Unknown = 0,
            Person,
            Centre
        }

        public enum DocumentTypes
        {
            [Description("Treatment Invoice")]
            TreatmentInvoice = 0,
            [Description("Statement")]
            Statement,
            [Description("Miscellaneous Invoice")]
            MiscellaneousInvoice,
            [Description("Renewal Invoice")]
            RenewalInvoice,
            [Description("Storage Invoice")]
            StorageInvoice,
            [Description("EUTD Annual Fee")]
            EUTDAnnualFee,
            [Description("EUTD Application Fee")]
            EUTDApplicationFee,
            [Description("Initial Fee")]
            InitialFee,
            [Description("Variation")]
            Variation,
            [Description("Credit note")]
            CreditNote

        }

        public enum MonthsList
        {
            Unknow = 0,
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
    }
}
