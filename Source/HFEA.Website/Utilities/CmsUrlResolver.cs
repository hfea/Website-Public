using HFEA.Web.ViewModel;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace HFEA.Web.Utilities
{
    public class CmsUrlResolver : ICmsUrlResolver
    {
        public string GetCmsUrlByContentId(int contentId)
        {
            string result = string.Empty;

            if (contentId > 0)
            {
                var helper = new UmbracoHelper(UmbracoContext.Current);

                IPublishedContent item = helper.TypedContent(contentId);

                if (item == null)
                {  // try media               
                    item = helper.TypedMedia(contentId);
                }

                if (item != null && item.Id != 0)
                {
                    result = item.Url();
                }
            }

            return result;
        }
    }
}
