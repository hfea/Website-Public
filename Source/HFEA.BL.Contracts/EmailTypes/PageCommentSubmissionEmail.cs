using HFEA.BL.Contracts.Mapper;


namespace HFEA.BL.Contracts.EmailTypes
{
    public class PageCommentSubmissionEmail : BaseEmail
    {
        public PageCommentSubmissionEmail(IMapper contentMapper) : base(contentMapper, Core.Config.Settings.KeyPages.CommentSubmissionEmail)
        {
        }   
    }
}
