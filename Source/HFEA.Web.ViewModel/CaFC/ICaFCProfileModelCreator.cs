namespace HFEA.Web.ViewModel.CaFC
{
    public interface ICaFCProfileModelCreator
    {
        CaFCProfileViewModel GetViewModel(int clinicId);
    }
}