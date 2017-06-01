using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Tasks
{
    public class TaskItem
    {
        public int TaskID { get; set; }
        public Constants.Centre.MonitoringItemType TaskTypeID { get; set; }
        public string TaskTypeDescription { get; set; }
        public int AreaTypeID { get; set; }
        public string AreaTypeDescription { get; set; }
        public int DegreeOfNonComplianceID { get; set; }
        public string DegreeOfNonComplianceDescription { get; set; }
        public int CentreID { get; set; }
        public int MonitoringActionID { get; set; }
        public int PriorityId { get; set; }
        public string PriorityDescription { get; set; }
        public Constants.Centre.RagPriority StatusID { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Constants.Centre.RagPriority StatusDescription { get; set; }
        public string ActionRequired { get; set; }
        public string ActionResponse { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string DueDate { get; set; }
    }
}
