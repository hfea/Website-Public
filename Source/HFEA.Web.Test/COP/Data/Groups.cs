using HFEA.Connector.Contracts.COP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Test.COP.Data
{
    public class Groups
    {
        public static COPItem Data
        {
            get
            {
                return JsonConvert.DeserializeObject<COPItem>(data);
            }
        } 
        private const string data = @"
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
          ""commaseparatedsearchtags"": """",
          ""copdocument"": null
        }
      ]
    },
    {
      ""groupname"": ""Test section"",
      ""copsections"": [
        {
          ""sectionumber"": ""2"",
          ""sectioname"": ""Councelling"",
          ""copacts"": [],
          ""coplicenceconditions"": [],
          ""copdirections"": [],
          ""copregulatoryprinciples"": [],
          ""copversiondatas"": [],
          ""commaseparatedsearchtags"": """",
          ""copdocument"": null
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
          ""commaseparatedsearchtags"": """",
          ""copdocument"": null
        }
      ]
    },
    {
      ""groupname"": ""Information and consent"",
      ""copsections"": []
    },
    {
      ""groupname"": ""Multiple births"",
      ""copsections"": []
    },
    {
      ""groupname"": ""Welfare of the child"",
      ""copsections"": []
    },
    {
      ""groupname"": ""Embryo testing"",
      ""copsections"": []
    },
    {
      ""groupname"": ""Donation and surrogacy"",
      ""copsections"": []
    },
    {
      ""groupname"": ""Use of gametes and embryos"",
      ""copsections"": []
    },
    {
      ""groupname"": ""Research and training"",
      ""copsections"": []
    },
    {
      ""groupname"": ""Facilities and administration"",
      ""copsections"": []
    },
    {
      ""groupname"": ""Treating people fairly"",
      ""copsections"": []
    },
    {
      ""groupname"": ""Record keeping and other obligations"",
      ""copsections"": []
    },
    {
      ""groupname"": ""Mitochondrial donation"",
      ""copsections"": []
    }
  ],
  ""copsections"": [],
  ""copdocument"": {
    ""url"": null,
    ""title"": null,
    ""filesize"": null,
    ""filetype"": null
  }
}";
    }
}
