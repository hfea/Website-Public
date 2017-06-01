using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.COP
{
    public class COPSection
    {
        public int SectionNumberInt
        {
            get
            {
                int res;
                int.TryParse(this.SectionNumber, out res);

                return res;
            }
        }

        [JsonProperty("sectionumber")]
        public string SectionNumber { get; set; }
        [JsonProperty("sectioname")]
        public string SectionName { get; set; }
        public List<COPContent> COPActs { get; set; }
        public List<COPContent> COPLicenceConditions { get; set; }
        public List<COPContent> COPDirections { get; set; }
        public List<COPContent> COPRegulations { get; set; }
        public List<COPContent> COPVersionDatas { get; set; }
        public List<COPContent> COPReferences { get; set; }
        public string CommaSeparatedSearchTags { get; set; }
        public COPFile COPDocument { get; set; }

        [JsonProperty("versionno")]
        public string VersionNo { get; set; }
        public string URL { get; set; }

    }
}
