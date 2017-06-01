using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.BL.Contracts.Mapper;
using Umbraco.Web;
using Our.Umbraco.Ditto;

namespace HFEA.CMS.Mapper
{
    public class MappingUtility : IMapper
    {
        private readonly UmbracoHelper _umbracoHelper;

        public MappingUtility(UmbracoHelper umbracoHelper)
        {
            this._umbracoHelper = umbracoHelper;
        }

       public T Map<T>(int nodeId) where T : class, IBaseCmsContent
        {
            return _umbracoHelper.TypedContent(nodeId).As<T>();
        }
    }
 }

