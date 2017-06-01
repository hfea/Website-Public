using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC
{
    public class SubmittedSearchParameters
    {
        public string Source { get; set; }
        public string Radius { get; set; }
        public string Options { get; set; }
        public string PageSize { get; set; }
        public string PageNumber { get; set; }
        public string Sort { get; set; }
        public string NumberOfResults { get; set; }

        public string ShowingResultsFor { get; set; }
    }
}
