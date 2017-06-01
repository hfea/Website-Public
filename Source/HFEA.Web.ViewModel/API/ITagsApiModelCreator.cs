using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.API
{
    public interface ITagsApiModelCreator
    {
        List<ContentTag> GetTagList();

        List<ContentTag> GetWebsiteProductTagList();
    }
}
