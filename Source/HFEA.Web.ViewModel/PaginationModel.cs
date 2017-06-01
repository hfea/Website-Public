using HFEA.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel
{
    public class PaginationModel : IPaginationModel
    {
        public bool IsValid
        {
            get
            {
                return Page > 0 && PageSize > 0 && TotalRecords >= 0
                    && (Page == 1 || PageSize * (Page - 1) + 1 <= TotalRecords);
            }
        }

        public int Page { get; set; }

        public int PageSize { get; set; }

        public int TotalRecords { get; set; }

        public int TotalPages
        {
            get
            {
                var pages = PageSize == 0 ? 0 : (int)Math.Ceiling((double)TotalRecords / (double)PageSize);
                return  pages > 0 ? pages: 0;
            }
        }
    }
}
