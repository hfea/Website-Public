using HFEA.Web.ViewModel.CaFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Helpers
{
    public class CafcQueryStringHelper : ICafcQueryStringHelper
    {
        private const string Separator = ",";
        
        public string GetQueryString(CaFCFiltersViewModel filters)
        {
            string result = string.Empty;
            List<string> parameters = new List<string>();

            if (filters != null)
            {
                if (!string.IsNullOrEmpty(filters.Location))
                {
                    parameters.Add(this.GetParameter(Constants.CaFC.QueryString.location, filters.Location));
                }

                if (filters.DistanceAsNullableInt.GetValueOrDefault() > 0)
                {
                    parameters.Add(this.GetParameter(Constants.CaFC.QueryString.distance, filters.Distance.ToString()));
                }
                if (filters.DynamicFilters != null)
                {
                    var dynamicValues = filters.DynamicFilters.SelectMany(x => x.ItemList).Where(x => x.Value).Select(x => x.Id);
                    if (dynamicValues.Any())
                    {
                        parameters.Add(this.GetParameter(Constants.CaFC.QueryString.options, string.Join(Separator, dynamicValues)));
                    }
                }
            }

            return string.Join("&", parameters);
        }

        public string GetQueryString(SearchParameters filters)
        {
            List<string> parameters = new List<string>();

            if (filters != null && !filters.IsEmpty)
            {
                if (!string.IsNullOrEmpty(filters.Source))
                {
                    parameters.Add(this.GetParameter(Constants.CaFC.QueryString.location, filters.Source));
                }

                if (filters.Distance > 0)
                {
                    parameters.Add(this.GetParameter(Constants.CaFC.QueryString.distance, filters.Distance.ToString()));
                }

                if (filters.PageSize > 0)
                {
                    parameters.Add(this.GetParameter(Constants.CaFC.QueryString.pageSize, filters.PageSize.ToString()));
                }

                if (filters.PageNumber > 0)
                {
                    parameters.Add(this.GetParameter(Constants.CaFC.QueryString.page, filters.PageNumber.ToString()));
                }

                if (filters.Sort > 0)
                {
                    parameters.Add(this.GetParameter(Constants.CaFC.QueryString.sort, filters.Sort.ToString()));
                }

                if (filters.Options != null && filters.Options.Any())
                {
                    parameters.Add(this.GetParameter(Constants.CaFC.QueryString.options, string.Join(Separator, filters.Options)));
                }
            }

            return string.Join("&", parameters);
        }

        public SearchParameters GetFilterValuesFromString(string location, string distance, string options, string page, string sort)
        {
            var result = new SearchParameters();
            
            if (!string.IsNullOrEmpty(location))
            {
                result.Source = location;
            }

            int tmp;

            if (!string.IsNullOrEmpty(options))
            {
                var optionList = options
                    .Split(new string[] { Separator }, StringSplitOptions.RemoveEmptyEntries);

                List<int> validOptions = new List<int>();

                foreach(var option in optionList)
                {
                    if (int.TryParse(option, out tmp))
                    {
                        validOptions.Add(tmp);
                    }
                }

                if (validOptions.Any())
                {
                    result.Options = validOptions;
                }
            }

            if (!string.IsNullOrEmpty(distance) && int.TryParse(distance, out tmp) && tmp > 0)
            {
                result.Distance = tmp;
            }

            if (!string.IsNullOrEmpty(page) && int.TryParse(page, out tmp))
            {
                result.PageNumber = tmp;
            }

            if (!string.IsNullOrEmpty(sort) && int.TryParse(sort, out tmp))
            {
                result.Sort = tmp;
            }

            return result;
        }

        private string GetParameter(Constants.CaFC.QueryString param, string value)
        {
            return string.Format("{0}={1}", param.ToString(), value);
        }
    }
}
