using HFEA.Connector.Contracts.Api;
using HFEA.Connector.Contracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.AccessControl
{
    public interface ITagsReader
    {
        List<ContentTag> GetContentTagList();

        List<ContentTag> GetPortalProductTagList();

        List<ContentTag> GetWebsiteProductTagList();
    }
}
