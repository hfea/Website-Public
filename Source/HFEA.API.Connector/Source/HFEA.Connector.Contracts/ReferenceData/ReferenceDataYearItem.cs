using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ReferenceData
{
    public class ReferenceDataYearItem
    {
        public int ReleaseYear { get; set; }
        public List<ReferenceDataItem> ReferenceDatas { get; set; }
    }
}
