using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ReferenceData
{
    public class ListingDataItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public string Summary { get; set; }
        public string CommaSeparatedSearchTags { get; set; }
        public string CommaSeparatedProductTags { get; set; }
    }
}
