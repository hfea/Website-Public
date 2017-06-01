using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.API
{
    public class PageCommentsItem
    {
        public int Id { get; set; }

        public int PageId { get; set; }

        public int? ParentId { get; set; }

        public string PageTitle { get; set; }

        public string PageUrl { get; set; }

        public string UserFullName { get; set; }

        public string UserEmail { get; set; }

        public bool IsApproved { get; set; }

        public string Text { get; set; }

        public string DateCreated { get; set; }

        public string DateModified { get; set; }

        public string ModifiedBy { get; set; }
    }
}
