using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class BirthStatisticsInfo
    {
        public int Year { get; set; }

        public bool HasValidData
        {
            get
            {
                return this.HasIuiData || this.HasDiData || this.HasIvfData;
            }
        }

        public string GenericTreatmentTitle { get; set; }
        public int GenericTreatmentClinicValue { get; set; }
        public int GenericTreatmentNationalValue { get; set; }
        public bool HasIvfData { get; set; }
        public bool HasIuiData { get; set; }
        public bool HasDiData { get; set; }
        public string StatsPageUrl { get; set; }
        public StatisticsDataSet BirthsPerEmbryo { get; set; }

        public StatisticsDataSet BirthsPerEggCollection { get; set; }

        public StatisticsDataSet MultipleBirthsPerCycle { get; set; }

        public StatisticsDataSet IUIBirths { get; set; }

        public StatisticsDataSet DIBirths { get; set; }

        public TimeSeries ChartData { get; set; }

        public string CaveatText { get; set; }

        // Additonal properties for Statistic period
        // Success Rate Date range
        public string Ivfemb_ivfmultb_dicyc_DataDateRangeStart { get; set; }
        public string Ivfemb_ivfmultb_dicyc_DataDateRangeEnd { get; set; }
        public string IvfeggcollCBR_DataDateRangeStart { get; set; }
        public string IvfeggcollCBR_DataDateRangeEnd { get; set; }
        public string Iui_DataDateRangeStart { get; set; }
        public string Iui_DataDateRangeEnd { get; set; }

    }
}
