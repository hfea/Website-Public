using HFEA.Web.ViewModel.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC
{
    public interface ICaFCNameSearchModelCreator
    {
        List<IdValueDescription> GetClinicNameAutocompleteValues();
    }
}
