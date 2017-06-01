
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
    public class ClinicProfileReader : BaseSdkClient, IClinicProfileReader
    {
        public ClinicProfileReader(ITokenResolver tokenResolver, IHfeaLogger logger) : base(tokenResolver, logger)
        { }

        public CentrePortal GetCentrePortalData(int centreId)
        {
            if (centreId <= 0) { throw new ArgumentOutOfRangeException("Clinic ID value is invalid"); }

            try
            {
                var CentrePortalData = this.ApiClient.GetCentrePortal(centreId.ToString());     
                       
                CentrePortal result = Mapper.Map<CentrePortal>(CentrePortalData);
                return result;
            }
            catch(Exception ex)
            {
                string message = ex.Message;
            }
           

            return null;
        }
    }
}
