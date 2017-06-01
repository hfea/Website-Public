using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CentreDashboard
{
    public class Message
    {
        public int Id { get; set; }
        public int? CentreId { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int PriorityLookupId { get; set; }
        public string PriorityDescription { get; set; }  
        public string PublishedDate { get; set; }
        public string ExpiryDate { get; set; }
        public string Url { get; set; }
        public string UrlTitle { get; set;}
    }
}
