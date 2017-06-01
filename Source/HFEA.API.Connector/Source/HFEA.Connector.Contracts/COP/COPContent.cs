using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.COP
{
    public class COPContent
    {
        public int Id { get; set; }
        public string SectionNumber { get; set; }
        public string Description { get; set; }
        public string FormatType { get; set; }
        public string Url { get; set; }
        public List<COPContent> COPVersionDatas { get; set; }
        public List<COPContent> COPReferences { get; set; }
    }
}
