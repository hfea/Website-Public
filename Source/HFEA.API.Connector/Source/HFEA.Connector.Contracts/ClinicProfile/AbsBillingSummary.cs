using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ClinicProfile
{
   public class AbsBillingSummary
    {
        public int SummaryId { get; set; }
        public DateTime BillingDate { get; set; }
        public decimal? IvfAmount { get; set; }
        public int? IvfQuantity { get; set; }
        public decimal? DiAmount { get; set; }
        public int? DiQuantity { get; set; }
        public decimal? MonthTotal { get; set; }
        public int? IvfMonthlyVariance { get; set; }
        public int? DiMonthlyVariance { get; set; }
        public List<AbsBillingImage> AbsBillingImages { get; set; }
    }
}
