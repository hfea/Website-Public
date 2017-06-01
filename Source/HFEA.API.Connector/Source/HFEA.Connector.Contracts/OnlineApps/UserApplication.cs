using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.OnlineApps
{
    public class UserApplication
    {
        public int? ApplicationCategoryID { get; set; }
        public string ApplicationCategory { get; set; }
        public int ApplicationID { get; set; }
        public string ApplicationName { get; set; }
        public int? CentreID { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedByName { get; set; }
        public int? ReplicationID { get; set; }
        public bool? Submittable { get; set; }
        public bool? UserCreatable { get; set; }
        public string SubmissionButton { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? CommitteeDate { get; set; }
        public string UpdatedByName { get; set; }
        public Guid UserApplicationID { get; set; }
        public List<UserDocument> UserDocuments { get; set; }
        public string WfState { get; set; }
    }
}
