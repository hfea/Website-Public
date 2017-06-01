using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC
{
    public interface ICaFCSearchFiltersModelCreator
    {
     //   CaFCNameSearchViewModel GetClinicNameSearchViewModel(string clinicName);

        CaFCFiltersViewModel GetCaFCFiltersViewModel(SearchParameters filterList);

        //CaFCNameSearchViewModel GetClinicSearchAtoZViewModel(string clinicAlpha);
    }
}
