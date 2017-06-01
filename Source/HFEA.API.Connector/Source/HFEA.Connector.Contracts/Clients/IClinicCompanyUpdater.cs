using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.ClinicProfile.PostUpdateModel;

namespace HFEA.Connector.Contracts.Clients
{
    public interface IClinicCompanyUpdater
    {
        bool Update(UpdateCentreInformationEntity companyType, int centreId);
    }
}
