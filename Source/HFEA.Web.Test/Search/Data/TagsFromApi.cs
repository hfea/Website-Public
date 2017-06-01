
using HFEA.Connector.Contracts.Api;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HFEA.Web.Test.Search.Data
{
    public class TagsFromApi
    {
        public static List<ContentTag> Data
        {
            get
            {
                return JsonConvert.DeserializeObject<List<ContentTag>>(data);
            }
        }

        private const string data = @"
[
  {
    ""Id"": 4001,
    ""Description"": ""Surrogacy""
  },
  {
    ""Id"": 4002,
    ""Description"": ""Legal parenthood""
  },
  {
    ""Id"": 4003,
    ""Description"": ""Another tag""
  }
]
";
    }
}
