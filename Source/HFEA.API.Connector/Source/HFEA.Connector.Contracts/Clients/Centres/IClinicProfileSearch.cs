using HFEA.Connector.Contracts.ClinicProfile;

namespace HFEA.Connector.Contracts.Clients.Centres
{
    public interface IClinicProfileSearch
    {
        Clinic GetClinicProfile(int clinicId);
    }
}
