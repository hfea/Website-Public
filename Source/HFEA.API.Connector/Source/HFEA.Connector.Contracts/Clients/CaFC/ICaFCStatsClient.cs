using HFEA.Connector.Contracts.CaFC.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.CaFC
{
    public interface ICaFCStatsClient
    {
        ClinicStatsDataSet GetClinicStats(int clinicId, string year, string age, string treatment, string source);

        ClinicStatsFilterCombinations GetClinicSearchFilters(int clinicId);

    }
}
