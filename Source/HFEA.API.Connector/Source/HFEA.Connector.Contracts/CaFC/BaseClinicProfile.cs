using HFEA.Connector.Contracts.CommonObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC
{
    public class BaseClinicProfile
    {
        public int Id { get; set; }
        public string CentreName { get; set; }
        public int CentreType { get; set; }
        public string CentreTypeDescription { get; set; }
        public string ProfileImageUrl { get; set; }
        [JsonProperty("links")]
        public List<Link> SatelliteClinics { get; set; }
        public MainAddress MainAddress { get; set; }
        public List<OpeningTime> OpeningTimes { get; set; }
        public List<IdNameDescription> TreatmentsOffered { get; set; }
        public List<IdNameDescription> EligibilityAndFunding { get; set; }
        public List<IdNameDescription> Staff { get; set; }
        public List<IdNameDescription> Facilities { get; set; }
        public List<IdNameDescription> DonorServices { get; set; }
        public List<IdNameDescription> ScreeningServices { get; set; }
        public List<IdNameDescription> CounsellingAndSupport { get; set; }
        public WaitingTimes SpermDonorWaitingTimes { get; set; }
        public WaitingTimes EggDonorWaitingTimes { get; set; }
        public WaitingTimes EmbryoDonorWaitingTimes { get; set; }
    }
}
