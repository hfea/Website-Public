using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HFEA.Web.ViewModel.Constants;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class TreatmentItem
    {
        public string Title { get; set; }

        Dictionary<CaFCConstants.TreatmentType, string> TreatmentOptionDictionary { get; set; }
    }
}
