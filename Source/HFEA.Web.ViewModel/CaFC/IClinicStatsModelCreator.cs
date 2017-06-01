using HFEA.Web.ViewModel.CaFC.Model;
using HFEA.Web.ViewModel.Constants;
using System.Collections.Generic;

namespace HFEA.Web.ViewModel.CaFC
{
    public interface IClinicStatsModelCreator
    {
        ClinicStatsViewModel GetViewModel(int clinicId, string year, string age, string treatment, string source, CaFCConstants.StatsTreatmentType statsType);

        StatsSearchFilterValues GetAvailableFiltersByData(int clinicId, string year, string age, string treatment, string source);
    }
}
