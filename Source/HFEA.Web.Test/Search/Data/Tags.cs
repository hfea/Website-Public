using HFEA.Web.ViewModel.API;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HFEA.Web.Test.Search.Data
{
    public class Tags
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
    ""id"": 4001,
    ""val"": ""Surrogacy""
    },
    {
    ""id"": 4002,
    ""val"": ""Legal parenthood""
    },
    {
    ""id"": 4003,
    ""val"": ""Another tag""
    }
]
";
    }
}
