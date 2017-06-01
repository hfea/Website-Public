using HFEA.Connector.Contracts.Clients.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Connector.Contracts.Api;
using HFEA.Connector.Service.Clients;
using HFEA.Connector.Contracts.ClientFactories;

namespace HFEA.Connector.Service.Client.Api
{
    public class TagsReader : BaseGetClient, ITagsReader
    {
        public TagsReader(IGetClientFactory client) : base(client)
        {
        }

        public virtual List<ContentTag> GetContentTagList()
        {
            return Factory.GetApiClient(Constants.ApiType.Search.Tags).ExecuteRequest<List<ContentTag>>();
        }

        public virtual List<ContentTag> GetPortalProductTagList()
        {
            return Factory.GetApiClient(Constants.ApiType.Search.ProductTagsPortal)
                .ExecuteRequest<List<ContentTag>>();
        }

        public virtual List<ContentTag> GetWebsiteProductTagList()
        {
            return Factory.GetApiClient(Constants.ApiType.Search.ProductTagsWebsite)
                .ExecuteRequest<List<ContentTag>>();
        }
    }
}
