using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Data.Contracts.Model
{

    public class PageComment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ParentComment")]
        public int? ParentId { get; set; }

        public int PageId { get; set; }

        public PageComment ParentComment { get; set; }
        
        public string Text { get; set; }

        public string Name { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public bool IsApproved { get; set; }

        public bool? IsDeleted { get; set; } // As of 28/4/2015 we don't use this field. Later IsDeleted flag is likely to replace comment deleting functionality
        

        public ICollection<PageComment> PageComments { get; set; }
    }
}
