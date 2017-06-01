using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Connector.Service.Constants;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System;
using HFEA.Connector.Service.Extensions;
using HFEA.Connector.Global;
using HFEA.Connector.Contracts.CaFC.Stats;

namespace HFEA.Connector.Service.Clients.CaFC
{
    public class CaFCStatsClientCachedAdaptor : CaFCStatsClient
    {
        private readonly IContentCacheService cacher;

        // default cache expiration is set to 15 minutes
        private readonly TimeSpan cacheTimeout = new TimeSpan(0, 15, 0);

        public CaFCStatsClientCachedAdaptor(IGetClientFactory client, IContentCacheService cacheProvider) : base(client)
        {
            if (cacheProvider == null) throw new ArgumentNullException("Stats reader cache provider is null");
            this.cacher = cacheProvider;
        }

        public override ClinicStatsDataSet GetClinicStats(int clinicId, string year, string age, string treatment, string source)
        {
            var param = this.GetIdParam(clinicId);
            var qryParam = this.GetQueryParams(year, age, treatment, source);
            string key = Helpers.UrlHelper.GetUrlWithParameters(ApiType.Centre.GetClinicStatistics.GetDescription(), param, qryParam);

            Func<ClinicStatsDataSet> client = () => base.GetClinicStats(clinicId, year, age, treatment, source);
            var result = this.cacher.GetResultsOrSetCache<ClinicStatsDataSet>(key, client);

            return result;
        }

        public override ClinicStatsFilterCombinations GetClinicSearchFilters(int clinicId)
        {
            var param = this.GetIdParam(clinicId);
            string key = Helpers.UrlHelper.GetUrlWithParameters(ApiType.Centre.GetClinicStatisticsFilters.GetDescription(), param, null);

            Func<ClinicStatsFilterCombinations> client = () => base.GetClinicSearchFilters(clinicId);
            var result = this.cacher.GetResultsOrSetCache<ClinicStatsFilterCombinations>(key, client);

            return result;
        }

    }
}
