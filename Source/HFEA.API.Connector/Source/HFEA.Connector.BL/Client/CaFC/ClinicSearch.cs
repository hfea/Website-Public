using HFEA.Connector.Contracts.CaFC;
using HFEA.Connector.Contracts.ClientFactories;
using HFEA.Connector.Contracts.Clients.CaFC;
using HFEA.Connector.Service.Constants;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System;

namespace HFEA.Connector.Service.Clients.CaFC
{
    public class ClinicSearch : BaseGetClient,  ICaFCSearch
    {
        private const string OptionsDelimeter = ",";

        public ClinicSearch(IGetClientFactory client) : base(client)
        {
        }

        public string GetAllClinicListJSON()
        {
            // no need to sort? ok for cafc search page
            return Factory.GetApiClient(ApiType.Search.GetCentreList).ExecuteRequestGetJson(null, null);
        }

        public List<Clinic> GetAllClinicList()
        {
            return Factory.GetApiClient(ApiType.Search.GetCentreList).ExecuteRequest<List<Clinic>>();
        }

        public List<Clinic> GetAllClinicList(int sort)
        {
            var parameters = this.GetSearchParams(sort: sort);
            return Factory.GetApiClient(ApiType.Search.GetCentreList).ExecuteRequest<List<Clinic>>(null, parameters);
        }

        public SearchFilters GetSearchTerms()
        {
            return Factory.GetApiClient(ApiType.Search.Terms).ExecuteRequest<SearchFilters>();
        }

        public SearchResults GetClinicList()
        {
            return Factory.GetApiClient(ApiType.Search.GetCaFCCentreList).ExecuteRequest<SearchResults>();
        }

        public SearchResults GetClinicList(string place, int? distance, char firstChar, List<int> options, int pageSize, int page, int sort)
        {
            var parameters = this.GetSearchParams(place, distance, firstChar, options, pageSize, page, sort);

            var temp = Factory.GetApiClient(ApiType.Search.GetCaFCCentreList).ExecuteRequest<object>(null, parameters);
            return Factory.GetApiClient(ApiType.Search.GetCaFCCentreList).ExecuteRequest<SearchResults>(null, parameters);
        }

        private NameValueCollection GetSearchParams(
            string place = "", int? distance = null, char firstChar = char.MinValue, 
            List<int> options = null, int pageSize = 0, int page = 0, int sort = 0)
        {
            var result = new NameValueCollection();

            if (!string.IsNullOrWhiteSpace(place))
            {
                result.Add(ApiParams.Source, place);
            }

            if (distance != null)
            {
                result.Add(ApiParams.Radius, distance.ToString());
            }

            if (char.IsLetterOrDigit(firstChar))
            {
                result.Add(ApiParams.FirstCharacter, firstChar.ToString());
            }

            if (options != null && options.Any())
            {
                result.Add(ApiParams.Options, string.Join(OptionsDelimeter, options));
            }

            if (page > 0)
            {
                result.Add(ApiParams.PageNumber, page.ToString());
            }

            if (pageSize > 0)
            {
                result.Add(ApiParams.PageSize, pageSize.ToString());
            }

            if (sort > 0)
            {
                result.Add(ApiParams.Sort, sort.ToString());
            }

            return result;
        }

        public List<SearchClinic> GetAllSearchClinicList()
        {
            return Factory.GetApiClient(ApiType.Search.GetCentreSearchList).ExecuteRequest<List<SearchClinic>>();
        }

        public List<SearchClinic> GetAllSearchClinicList(int sort)
        {
            var parameters = this.GetSearchParams(sort: sort);
            return Factory.GetApiClient(ApiType.Search.GetCentreSearchList).ExecuteRequest<List<SearchClinic>>(null, parameters);
        }
    }
}
