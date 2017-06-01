namespace HFEA.Web.ViewModel.COP
{
    public interface ICOPModelCreator
    {
        COPViewModel GetViewModel();

        COPViewModel GetViewModel(string activeGroup);
    }
}