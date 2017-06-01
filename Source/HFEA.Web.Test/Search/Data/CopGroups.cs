using HFEA.Connector.Contracts.COP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Test.Search.Data
{
    public class CopGroups
    {
        public static COPItem Data
        {
            get
            {
                return JsonConvert.DeserializeObject<COPItem>(data);
            }
        }

        private static string data = @"
{
  ""description"": ""8th Edition"",
  ""copgroups"": [
    {
      ""groupname"": ""Staff"",
      ""copsections"": [
        {
          ""sectionumber"": ""1"",
          ""sectioname"": ""Person Responsible"",
          ""copacts"": [],
          ""coplicenceconditions"": [],
          ""copdirections"": [],
          ""copregulatoryprinciples"": [],
          ""copversiondatas"": [],
          ""commaseparatedsearchtags"": """"
        }
      ]
    },
    {
      ""groupname"": ""Councelling"",
      ""copsections"": [
        {
          ""sectionumber"": ""3"",
          ""sectioname"": ""Councelling"",
          ""copacts"": [],
          ""coplicenceconditions"": [],
          ""copdirections"": [],
          ""copregulatoryprinciples"": [],
          ""copversiondatas"": [],
          ""commaseparatedsearchtags"": """"
        }
      ]
    }
  ],
  ""copsections"": []
}
";
    }
}
