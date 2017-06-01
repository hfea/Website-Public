using HFEA.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.COP
{
    public class COPViewModel : COPNavigationViewModel
    {
        public bool IsValid
        {
            get
            {
                return this.ActiveSection != null;
            }
        }

        public bool HasGuidanceData
        {
            get
            {
                return this.ActiveSection?.GuidanceList != null && this.ActiveSection.GuidanceList.Any();
            }
        }

        public bool HasFilesList
        {
            get
            {
                return this.ActiveSection?.FileList != null && this.ActiveSection.FileList.Any();
            }
        }

        public bool HasOtherReferences
        {
            get
            {
                return this.ActiveSection?.COPReferences != null && this.ActiveSection.COPReferences.Any();
            }
        }

        public COPSectionItem ActiveSection { get; set; }
    }
}
