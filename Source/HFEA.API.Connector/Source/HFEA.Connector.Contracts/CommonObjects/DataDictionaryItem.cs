using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CommonObjects
{
    public class DataDictionaryItem
    {
        public int EntityAdditionalInformationId { get; set; }
        public int? LookupItemId { get; set; }
        public string LookupItemName { get; set; }
        public int LookupItemParentId { get; set; }
        public string LookupItemParentDescription { get; set; }
        public string DataType { get; set; }
        public bool Checked { get; set; }
        public string Text { get; set; }
        public string FileUrl { get; set; }
    }
}
