using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ClinicProfile.PostUpdateModel
{
    public class UpdateCentreInformationEntity
    {
        public int EntityId { get; set; }
        public string LookupItemId { get; set; }
        public string LookupItemName { get; set; }
        public string LookupItemParentId { get; set; }
        public string ControlType { get; set; }
        public bool Checked { get; set; }
        public string Text { get; set; }
        public string FileUrl { get; set; }
    }
}
