using HFEA.Connector.Contracts.Clients.AccessControl;
using HFEA.Web.ViewModel.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.ModelCreators
{
    public class TagsApiModelCreator : ITagsApiModelCreator
    {
        private readonly ITagsReader reader;
        public TagsApiModelCreator(ITagsReader dataReader)
        {
            if (dataReader == null) { throw new ArgumentNullException("tags reader is null"); }

            this.reader = dataReader;
        }

        public List<ContentTag> GetTagList()
        {
            var data = reader.GetContentTagList();

            List<ContentTag> result = MapTagList(data);

            return result;
        }

        public List<ContentTag> GetWebsiteProductTagList()
        {
            var data = reader.GetWebsiteProductTagList();

            List<ContentTag> result = MapTagList(data);

            return result;
        }

        private List<ContentTag> MapTagList(List<Connector.Contracts.Api.ContentTag> data)
        {
            List<ContentTag> result = null;

            if (data != null)
            {
                result = data.Select(x => new ContentTag()
                {
                    Id = x.Id,
                    Value = x.Description
                }).ToList();
            }

            return result;
        }
    }
}
