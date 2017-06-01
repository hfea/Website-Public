using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.OnlineApps
{
    public class UserDocument
    {
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public string DocumentHeader { get; set; }
        public int? DocumentVersionID { get; set; }
        public string DocXML { get; set; }
        public int? ReplicationID { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }
        public Guid UserDocumentID { get; set; }
        public bool? Submittable { get; set; }
    }
}
