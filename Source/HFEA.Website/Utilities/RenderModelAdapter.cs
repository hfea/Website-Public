using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace HFEA.Web.Utilities
{
    public class RenderModelAdapter<T> : RenderModel
    {
        public T ViewModel { get; private set; }

        public UmbracoHelper Umbraco { get; private set; }

        public RenderModelAdapter(IPublishedContent content, T model) : base(content)
        {
            this.ViewModel = model;
        }

        public RenderModelAdapter(IPublishedContent content, T model, UmbracoHelper umbracoHelper) : base(content)
        {
            this.ViewModel = model;
            this.Umbraco = umbracoHelper;
        }
    }
}
