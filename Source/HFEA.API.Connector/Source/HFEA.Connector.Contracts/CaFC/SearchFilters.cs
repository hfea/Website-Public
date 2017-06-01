using HFEA.Connector.Contracts.CommonObjects;
using System.Collections.Generic;

namespace HFEA.Connector.Contracts.CaFC
{
    public class SearchFilters
    {
        public List<KeyValuePair<string, string>> CollectionNames { get; set; }
        public List<IdNameDescription> Treatments { get; set; }
        public List<IdNamePair> EligibilityAndFunding { get; set; }
        public List<IdNamePair> DonorRecruitment { get; set; }
        public List<IdNameDescription> ScreeningServices { get; set; }
        public List<IdNamePair> CounsellingAndSupport { get; set; }
        //public List<IdNamePair> NonLicensedTreatmentsAndServices { get; set; }
        public List<IdNamePair> SortableTerms { get; set; }
    }
}
