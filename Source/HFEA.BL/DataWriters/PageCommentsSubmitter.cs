using HFEA.BL.Contracts;
using HFEA.BL.Contracts.Mapper;
using HFEA.Core.Constants;
using HFEA.Data.Contracts.Model;
using HFEA.Data.Contracts.Writers;
using HFEA.Web.ViewModel.UserFeedback;
using System;
using System.Collections.Generic;

namespace HFEA.BL.DataWriters
{
    public class PageCommentsSubmitter : IPageCommentsSubmitter
    {
        private readonly IPageCommentWriter writer;
        private readonly IMapper mapper;
        private readonly IEmailSender emailer;

        public PageCommentsSubmitter(IPageCommentWriter dataWriter, IMapper contentMapper, IEmailSender emailSender)
        {
            if (dataWriter == null) throw new ArgumentNullException("comment data writer is null");
            if (contentMapper == null) throw new ArgumentNullException("CMS content mapper is null");
            if (emailSender == null) throw new ArgumentNullException("email sender is null");

            this.writer = dataWriter;
            this.mapper = contentMapper;
            this.emailer = emailSender;
        }

        public bool SubmitPageComment(CommentFormModel comment, int pageId)
        {
            bool result = false;

            if (comment != null)
            {
                var newComment = new PageComment()
                {
                    PageId = pageId,
                    ParentId = comment.ParentCommentId > 0 ? comment.ParentCommentId : null,
                    Name =  comment.Name.AntiXssEncode(),
                    Lastname = comment.Surname.AntiXssEncode(),
                    Email = comment.Email.AntiXssEncode(),
                    Text = comment.Comment, //.AntiXssEncode(),
                    IsApproved = false,
                    CreatedDate = DateTime.UtcNow 
                };

                if (this.writer.AddNewRecord(newComment))
                {
                    result = true;
                    this.SendConfirmationEmail(pageId);
                }
            }

            return result;
        }

        private bool SendConfirmationEmail(int pageId)
        {
            bool result = false;

            var email = new Contracts.EmailTypes.PageCommentSubmissionEmail(this.mapper);

            var page = this.mapper.Map<BaseCmsContent>(pageId);

            var replacements = new Dictionary<string, string>()
            {
                {EmailerConstants.PageName, page.Name },
                {EmailerConstants.PageUrl, page.Url }
            };
            
            var mapped = email.GetEmailObject(replacements);

            this.emailer.Send(mapped);

            return result;
        }
    }
}
