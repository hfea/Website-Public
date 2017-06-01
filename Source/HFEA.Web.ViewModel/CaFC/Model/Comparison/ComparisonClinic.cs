using HFEA.Web.ViewModel.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model.Comparison
{
    public class ComparisonClinic
    {
        public int ClinicId { get; set; }

        public string ClinicName { get; set; }

        public string ClinicType { get; set; }

        public string ProfileImage { get; set; }
        
        public RatingData Ratings { get; set; }

        public List<OpenTimeItem> OpeningTimesList { get; set; }
        public string OpeningTimesCaveat { get; set; }
        public List<string> AddressLines { get; set; }
        public ClinicGameteAvailability GameteAvailability { get; set; }
        public List<ComparisonDataItem> Eligibility { get; set; }
        public List<ComparisonDataItem> Treatments { get; set; }
        public List<ComparisonDataItem> DonorServices { get; set; }        
        public List<ComparisonDataItem> CounsellingAndSupport { get; set; }
        public List<ComparisonDataItem> Staffing { get; set; }
        public List<ComparisonDataItem> Facilities { get; set; }        
        public List<SatelliteClinicInfo> SatelliteClinicList { get; set; }
        public List<SatelliteClinicInfo> TransportClinicList { get; set; }

        public bool? GetPropertyValueById(int itemId, Func<ComparisonClinic, List<ComparisonDataItem>> listGetter)
        {
            bool? result = null;
            var dataList = listGetter(this);

            if (dataList != null)
            {
                result = dataList.FirstOrDefault(x => x.Id == itemId)?.Value;
            }

            return result;
        }
    }
}
