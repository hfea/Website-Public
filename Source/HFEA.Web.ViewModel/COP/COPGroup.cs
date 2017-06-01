using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.COP
{
    public class COPGroup
    {
        public bool IsActive { get; set; }

        public string GroupName { get; set; }

        public string FirstSectionUrl
        {
            get
            {
                if (this.SectionItemList != null && this.SectionItemList.Any())
                {
                    return this.SectionItemList.First().SectionUrl.ToString();
                }

                return string.Empty;
            }
        }

        public List<COPSectionItem> SectionItemList { get; set; }
    }
}
