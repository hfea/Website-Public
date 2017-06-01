using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.COP
{
    public class COPReferences
    {
        // IR
        public List<COPReferences> COPSubReferences { get; set; }
        public string COPVersionDatas { get; set; }
        public string Description { get; set; }
        public string FormatType { get; set; }
        public int Id { get; set; }
        public int SectionNumber { get; set; }
        public string Url { get; set; }
    }
}
