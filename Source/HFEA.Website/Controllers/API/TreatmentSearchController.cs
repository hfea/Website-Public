using HFEA.Connector.Global;
using HFEA.Core;
using HFEA.Web.ViewModel.API;
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
    /// This controller/action resolves to url: "/umbraco/api/treatmentsearch/[action]"
    /// </summary>
    public class TreatmentSearchController : UmbracoApiController
    {
        private const string CacheKey = "treatmentSearchData";
        private readonly IContentCacheService cache;
        public TreatmentSearchController(IContentCacheService cacheProvider)
        {
            if (cacheProvider == null) throw new ArgumentNullException("cache provider is null");
            this.cache = cacheProvider;
        }

        [AcceptVerbs("GET")]
        public List<IdValuePair> TreatmentSearchOptions()
        {
            var result = this.cache.Get<List<IdValuePair>>(CacheKey);

            if (result == null || !result.Any())
            {
                result = this.GetData();
                this.cache.Set(CacheKey, result);
            }
                
            return result;   
        }

        private List<IdValuePair> GetData()
        {
            var result = new List<IdValuePair>();

            var settingsNode = new Node(Config.Settings.KeyPages.Settings);

            if (settingsNode.Id > 0)
            {
                var container = settingsNode.ChildrenAsList.Where(x => x.NodeTypeAlias == Config.Settings.KeyDocTypes.TreatmentSearchContainer).FirstOrDefault();

                if (container != null)
                {
                    var options = container.ChildrenAsList.Where(x => x.NodeTypeAlias == Config.Settings.KeyDocTypes.TreatmentSearchOption);
                    foreach (var option in options)
                    {
                        var res = new IdValuePair()
                        {
                            Id = option.GetProperty("title").Value,
                            Value = Helpers.CmsHelper.GetUrlById(option.GetProperty("page").Value)
                        };
                        
                        result.Add(res);
                    }
                }
            }

            return result;
        }
    }
}