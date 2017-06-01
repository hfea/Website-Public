using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ReferenceData
{
    public class ReferenceDataItem
    {
        public int ItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Year { get; set; }
        public string ReleaseDate { get; set; }
        public List<ReferenceDataItem> ReferenceDatas { get; set; }

        public string FileExtension { get; set; }
        
        public string CommaSeparatedSearchTags { get; set; }
    }
}
