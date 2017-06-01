using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HFEA.Connector.Contracts.Centre
{
    public class EntityAdditionalInformation
    {
        public bool Checked { get; set; }

        public string DataType { get; set; }

        public int EntityId { get; set; }

        public int LookupItemId { get; set; }

        public string LookupItemName { get; set; }

        public int LookupItemParentId { get; set; }

        public string Text { get; set; }
        public string LookupItemParentDescription { get; set; }
     
        public DateTime? StartDate { get; set; }
       
        public DateTime? EndDate { get; set; }

        public Guid Id { get; set; }
    }
}
