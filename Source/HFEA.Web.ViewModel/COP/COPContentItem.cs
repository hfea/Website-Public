using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.COP
{
    public class COPContentItem
    {
        public string SectionNumber { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public ReferenceData.CopFormatType FormatType { get; set; }

        public List<COPContentItem> ItemList { get; set; }

        public List<COPContentItem> NotesList { get; set; }
    }
}
