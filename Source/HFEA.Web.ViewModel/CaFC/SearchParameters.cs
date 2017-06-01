using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC
{
    public class SearchParameters
    {
        public bool IsEmpty
        {
            get
            {
                return string.IsNullOrEmpty(Source) && (Options == null || Options.Any() == false)
                && Distance == 0 && PageSize == 0 && PageNumber == 0 && Sort == 0;
            }
        }
        public char FirstLetter { get; set; }
        public string Source { get; set; }
        public int? Distance { get; set; }
        public List<int> Options { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int Sort { get; set; }
    }
}
