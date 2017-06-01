using HFEA.Connector.Global;
using HFEA.Core;
using HFEA.Web.ViewModel.API;
using HFEA.Web.ViewModel.CaFC;
using HFEA.Web.ViewModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using umbraco.NodeFactory;
using Umbraco.Web.WebApi;

namespace HFEA.Web.Controllers
{
    /// <summary>
    /// This controller/action resolves to url: "/umbraco/api/clinicsearch/[action]"
    /// </summary>
    public class ClinicSearchController : UmbracoApiController
    {
        private const string CacheKey = "clinicAutocomplete";
        private readonly IContentCacheService cache;
        private readonly ICaFCNameSearchModelCreator model;

        public ClinicSearchController(IContentCacheService cacheProvider, ICaFCNameSearchModelCreator modelCreator)
        {
            if (cacheProvider == null) throw new ArgumentNullException("cache provider is null");
            if (modelCreator == null) throw new ArgumentNullException("model creator is null");
            this.cache = cacheProvider;
            this.model = modelCreator;
        }

        [AcceptVerbs("GET")]
        public List<IdValueDescription> AutoComplete()
        {
            var result = this.cache.GetResultsOrSetCache<List<IdValueDescription>>(
                    CacheKey, 
                    this.model.GetClinicNameAutocompleteValues);

            return result;   
        }
    }
}