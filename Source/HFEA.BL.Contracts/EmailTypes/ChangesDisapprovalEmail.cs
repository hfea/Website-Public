using HFEA.BL.Contracts.Mapper;


namespace HFEA.BL.Contracts.EmailTypes
{
    public class ChangesDisapprovalEmail : BaseEmail
    {
        public ChangesDisapprovalEmail(IMapper contentMapper) : base(contentMapper, Core.Config.Settings.KeyPages.ChangesDisapprovalEmail)
        {
        }
    }
}
