using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.Contracts.Search
{
    public interface IUmbracoContentReader
    {
        List<ISearchIndexItem> GetValidUmbracoNodeData();

        ISearchIndexItem GetValidUmbracoNodeDataById(int id);
    }
}
