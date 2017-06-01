
using HFEA.Connector.Contracts.Clients.Centres;
using HFEA.Connector.Service.BaseClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.Centre;
using HFEA.Connector.Global;
using AutoMapper;

namespace HFEA.Connector.Service.Client.Centres
{
    public class LicenceReader : BaseSdkClient, ILicenceReader
    {
        public LicenceReader(ITokenResolver tokenResolver, IHfeaLogger logger) : base(tokenResolver, logger)
        { }

        public async Task<List<Licence>> GetCenterLicenceList(int clinicId)
        {
            var portalInfo = await this.ApiClient.GetCentrePortalAsync(clinicId.ToString());

            var licences = portalInfo?.Licences;

            return Mapper.Map<List<Licence>>(licences);
        }

        public async Task<Licence> GetLicence(int clinicId, int licenceId)
        {
            var licence = await this.ApiClient.GetCentreLicenceAsync(clinicId.ToString(), licenceId.ToString());

            return Mapper.Map<Licence>(licence);
        }
    }
}
