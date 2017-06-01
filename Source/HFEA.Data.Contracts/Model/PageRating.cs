using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Data.Contracts.Model
{
    public class PageRating
    {
        [Key]
        public int Id { get; set; }

        public int CmsId { get; set; }

        public string CmsPageName { get; set; }

        public int Score { get; set; }
        
        public DateTime DateCreated { get; set; }

        public string UserIdentifier { get; set; }
    }
}
