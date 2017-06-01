using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ReferenceData
{
    public class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public string DocumentBodyHtml { get; set; }
        public string FooterTitle { get; set; }
        public string FooterHtml { get; set; }
        public string CommaSeparatedSearchTags { get; set; }
        public List<DocumentLink> ExternalLinks { get; set; }
        public List<DocumentLink> InternalLinks { get; set; }
    }
}
