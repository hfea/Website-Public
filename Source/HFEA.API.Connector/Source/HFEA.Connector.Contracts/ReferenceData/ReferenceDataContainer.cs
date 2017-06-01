using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ReferenceData
{
    public class ReferenceDataContainer
    {
        public string CategoryName { get; set; }
        public string CodingStandardType { get; set; }
        public List<ReferenceDataYearItem> ReferenceYears { get; set; }
        public List<ReferenceDataItem> ReferenceDatas { get; set; }
    }
}
