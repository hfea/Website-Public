using HFEA.Connector.Contracts.Clients.CaFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.CaFC.Stats;
using HFEA.Connector.Service.Clients;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Service.Constants;
using System.Collections.Specialized;

namespace HFEA.Connector.Service.Clients.CaFC
{
    public class CaFCStatsClient : BaseGetClient, ICaFCStatsClient
    {
        public CaFCStatsClient(IGetClientFactory factory) : base(factory) { }

        public virtual ClinicStatsDataSet GetClinicStats(int clinicId, string year, string age, string treatment, string source)
        {
            var routeParams = this.GetIdParam(clinicId);
            var qryParams = this.GetQueryParams(year, age, treatment, source);
            var res = this.Factory.GetApiClient(ApiType.Centre.GetClinicStatistics).ExecuteRequest<ClinicStatsDataSet>(routeParams, qryParams);
            return res;
        }

        public virtual ClinicStatsFilterCombinations GetClinicSearchFilters(int clinicId)
        {
            var param = this.GetIdParam(clinicId);
            var res = this.Factory.GetApiClient(ApiType.Centre.GetClinicStatisticsFilters).ExecuteRequest<ClinicStatsFilterCombinations>(param, null);
            return res;
        }

        protected NameValueCollection GetIdParam(int clinicId)
        {
            var result = new NameValueCollection();
            result.Add(ApiParams.Id, clinicId.ToString());

            return result;
        }

        protected NameValueCollection GetQueryParams(string year, string age, string treatment, string source)
        {
            var result = new NameValueCollection();

            result.Add(ApiParams.Year, year ?? string.Empty);
            result.Add(ApiParams.Age, age ?? string.Empty);
            result.Add(ApiParams.Source, source ?? string.Empty);
            result.Add(ApiParams.Treatment, treatment ?? string.Empty);

            return result;
        }
    }
}
