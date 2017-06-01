using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Inspection
{
    public class LCELPMinutes
    {
        public List<TreatmentCommitteeMinutes> TreatmentCommitteeMinutes { get; set; }
    }
    public class TreatmentCommitteeMinutes
    {
        public string DocumentTitle { get; set; }
        public string DocumentSummary { get; set; }
        public string DocumentDate { get; set; }
        public string FormattedSize { get; set; }
        public int Sequence { get; set; }
        public string InspectionDocumentType { get; set; }
        public string Url { get; set; }
        public string UrlTitle { get; set; }
    }
}
