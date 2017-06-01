using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Inspection
{
    public class InspectionReport
    {
        public List<TreatmentInspectionReports> TreatmentInspectionReports { get; set; }

        public List<TreatmentInspectionReports> AllDocumentsSortedByPublicationDate { get; set; }
    }
    public class TreatmentInspectionReports
    {
        public string DocumentDate { get; set; }
        public string DocumentSummary { get; set; }
        public string DocumentTitle { get; set; }
        public string FormattedSize { get; set; }
        public Int32 Sequence { get; set; }
        public string type { get; set; }
        public string UrlTitle { get; set; }
        public string Url { get; set; }
    }
}
