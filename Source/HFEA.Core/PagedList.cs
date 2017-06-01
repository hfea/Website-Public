using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Core
{
    public class PagedList<T> : Collection<T>, IPaginationModel
    {
        public PagedList(IEnumerable<T> list, int page, int pageSize, bool includeRecordCount)
            : base(list.Skip((page - 1) * pageSize).Take(pageSize).ToList())
        {
            Page = page;
            PageSize = pageSize;

            // If we need total records, hit the database and count the total records in the query
            if (includeRecordCount)
            {
                TotalRecords = list.Count();
                TotalPages = GetTotalPages();
            }
        }

        /// <summary>
        /// This constructor accepts already filtered / paged results and allows to manually set 
        /// pagelist parameters. Used when we need to pass to a pager already filtered results
        /// </summary>
        /// <param name="list">result list</param>
        /// <param name="page">page number</param>
        /// <param name="pageSize">page size</param>
        /// <param name="setTotalRecords">total records in collection</param>
        public PagedList(List<T> list, int page, int pageSize, int setTotalRecords)
            : base(list)
        {
            Page = page;
            PageSize = pageSize;
            TotalRecords = setTotalRecords;
            TotalPages = GetTotalPages();
        }
        public bool IsValid
        {
            get
            {
                return Page > 0 && PageSize > 0 && TotalRecords >= 0
                    && (Page == 1 || PageSize * (Page - 1) + 1 <= TotalRecords);
            }
        }

        public int Page { get; private set; }

        public int PageSize { get; private set; }

        public int TotalRecords { get; private set; }

        public int TotalPages { get; private set; }        

        private int GetTotalPages()
        {
            if (TotalRecords > 0)
            {
                return (int)Math.Ceiling((double)TotalRecords / (double)PageSize);
            }

            return 0;
        }
    }
}
