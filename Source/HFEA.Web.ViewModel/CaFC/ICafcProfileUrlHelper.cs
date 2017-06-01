namespace HFEA.Web.ViewModel.CaFC
{
    public interface ICafcProfileUrlHelper
    {
        string GetPageUrl(int clinicId);
        string GetFeedBackUrl(int clinicId);
        string GetStatsPageUrl(int clinicId);
    }
}