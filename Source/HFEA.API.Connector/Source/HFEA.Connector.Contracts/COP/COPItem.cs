using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.COP
{
    public class COPItem
    {
        public string Description { get; set; }
        public List<COPGroup> COPGroups { get; set; }
        public List<COPSection> COPSections { get; set; }
        public COPFile COPDocument { get; set; }

        // IR
        public List<COPReferences> COPReferences { get; set; }
    }
}
