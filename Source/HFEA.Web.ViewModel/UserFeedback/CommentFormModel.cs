using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.UserFeedback
{
    public class CommentFormModel
    {
        [ScaffoldColumn(false)]
        public int? ParentCommentId { get; set; }

        [Display(Name="First name")]
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "Name length cannot exceed 50 characters")]
        public string Name { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Surname is required")]
        [StringLength(50, ErrorMessage = "Surname length cannot exceed 50 characters")]
        public string Surname { get; set; }

        [Display(Name = "Email address (Optional)")]
        //[Required(ErrorMessage = "Email is required")]
        [RegularExpression(Core.Constants.ValidationRegex.Email, ErrorMessage = "Email format is wrong")]
        public string Email { get; set; }

        [Display(Name = "Your comment")]
        [Required(ErrorMessage = "Comment is required")]
        [StringLength(2000, ErrorMessage = "Comment length cannot exceed 2000 characters")]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }

    }
}
