using HFEA.Connector.Contracts.Tasks;
using System.Collections.Generic;

namespace HFEA.Connector.Contracts.CentreDashboard
{
    public class Dashboard
    {
        public int Id { get; set; }
        public string CentreName { get; set; }
        public PatientExperiences PatientExperiences { get; set; }
        public List<TaskItem> Tasks { get; set; }
        public List<Message> Messages { get; set; }
        public Performance Performance { get; set; }
    }
}
