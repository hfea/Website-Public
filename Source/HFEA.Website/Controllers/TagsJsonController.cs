using HFEA;
using HFEA.Web;
using HFEA.Web.ViewModel.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace My.Controllers
{
    /// <summary>
    /// This controller/action resolves to url: "/umbraco/api/tagsjson/[action]"
    /// </summary>
    public class TagsJsonController : UmbracoApiController
    {
        private readonly ITagsApiModelCreator modelUtility;
        public TagsJsonController(ITagsApiModelCreator modelCreator)
        {
            if (modelCreator == null) { throw new NullReferenceException("Tags model creator is null"); }
            this.modelUtility = modelCreator;
        }

        // GET: TagsJson
        public IEnumerable<ContentTag> GetAll()
        {
            return this.modelUtility.GetTagList();
        }

        public IEnumerable<ContentTag> GetAllProductTags()
        {
            return this.modelUtility.GetWebsiteProductTagList();
        }

        [AcceptVerbs("GET")]
        public IEnumerable<ContentTag> Autocomplete()
        {
            IEnumerable<ContentTag> result = new List<ContentTag>();

            string term = HFEA.Web.Constants.QueryString.QueryParams.term.GetQryParamValueOrNull();
            string tags = HFEA.Web.Constants.QueryString.QueryParams.tags.GetQryParamValueOrNull();
            List<int?> existingTagsList = !string.IsNullOrEmpty(tags)
                ? tags.Split(new char[] { ',' }).Select(x => x.ToNullableInt()).Where(x => x != null).ToList()
                : new List<int?>();

            if (!string.IsNullOrEmpty(term))
            {
                result = this.modelUtility.GetTagList()
                    .Where(x => !existingTagsList.Contains(x.Id) && x.Value.ContainsIgnoreCase(term));
            }

            return result;
        }
    }
}