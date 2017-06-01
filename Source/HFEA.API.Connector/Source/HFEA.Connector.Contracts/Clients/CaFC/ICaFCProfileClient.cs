namespace HFEA.Connector.Contracts.Clients.CaFC
{
    using Contracts.CaFC;

    public interface ICaFCProfileClient
    {
        ClinicProfile GetClinicProfile(int clinicId);
    }
}