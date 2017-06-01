using HFEA.Web.ViewModel.CaFC.Model;
using System.Collections.Generic;
using System.Linq;

namespace HFEA.Web.ViewModel.CaFC
{
    public class CaFCSearchViewModel
    {
        public bool IsFullListOfClinics
        {
            get
            {
                return (this.FilterTreatmentList == null || this.FilterTreatmentList.Any() == false) && string.IsNullOrEmpty(this.Location);
            }
        }

        public string Location { get; set; }

        public double Distance { get; set; }

        public List<MapInformation> MapDataList { get; set; }

        public string MapDataJSON { get; set; }

        public List<ClinicItem> ClinicList { get; set; }

        public PaginationModel PaginationData { get; set; }

        public int SortingParameter { get; set; }

        public int TotalRecords
        {
            get
            {
                return this.PaginationData != null ? this.PaginationData.TotalRecords : 0;
            }
        }

        public List<string> FilterTreatmentList { get; set; }

        public string SearchPageUrl { get; set; }
    }
}
