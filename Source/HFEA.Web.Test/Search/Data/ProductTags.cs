
using HFEA.Connector.Contracts.Api;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HFEA.Web.Test.Search.Data
{
    public class ProductTags
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
    ""Id"": 10001,
    ""Description"": ""Code of Practice""
  },
  {
    ""Id"": 10002,
    ""Description"": ""Directions""
  },
  {
    ""Id"": 10003,
    ""Description"": ""Chair's Letters""
  },
  {
    ""Id"": 10004,
    ""Description"": ""Chief Executive's Letters""
  },
  {
    ""Id"": 10005,
    ""Description"": ""Clinic Focus""
  },
  {
    ""Id"": 10006,
    ""Description"": ""License Conditions""
  }
]
";
    }
}
