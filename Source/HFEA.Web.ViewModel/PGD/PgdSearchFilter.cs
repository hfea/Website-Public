using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.PGD
{
    public class PgdSearchFilters
    {        
        public int Page { get; set; }

        public int PageSize { get; set; }

        [DisplayName("Status")]
        public PgdConstants.Status Status { get; set; }
        [DisplayName("Condition")]
        public string Condition { get; set; }
        [DisplayName("OMOIMM #")]
        public string OMOIMM { get; set; }
    }
}
