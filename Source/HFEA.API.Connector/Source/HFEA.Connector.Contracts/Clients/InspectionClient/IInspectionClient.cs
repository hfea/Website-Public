using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Contracts.Inspection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.InspectionClient
{
    public interface IInspectionClient
    {
        InspectionReport GetInspectionReport(int clinicId);
        InspectorDetails GetInspectorDetails(int clinicId);
        LCELPMinutes GetLCELPMinutes(int clinicId);
        InspectionRatingModel GetInspectionRating(int clinicId);
    }
}
