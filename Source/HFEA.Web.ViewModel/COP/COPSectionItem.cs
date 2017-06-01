using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.COP
{
    public class COPSectionItem
    {
        public bool IsValid
        {
            get { return this.SectionId != 0 && !string.IsNullOrEmpty(SectionName); }
        }

        public int SectionId
        {
            get
            {
                int result = 0;
                int.TryParse(this.SectionNumber, out result);

                return result;
            }
        }

        public string SectionNumber { get; set; }

        public string SectionName { get; set; }

        public string SectionUrl { get; set; }
        
        public List<COPContentItem> ActList { get; set; }

        public List<COPContentItem> LicenceConditionList { get; set; }

        public List<COPContentItem> DirectonsList { get; set; }

        public List<COPContentItem> GuidanceList { get; set; }

        /// <summary>
        ///  As of 14/9/2016 depreciated from COP
        /// </summary>
        //public List<COPContentItem> RegulatoryPrinciplesList { get; set; }

        public List<COPFile> FileList { get; set; }

        // IR Related links
        public List<COPContentItem> COPReferences { get; set; }
        public string VersionNo { get; set; }
    }
}
