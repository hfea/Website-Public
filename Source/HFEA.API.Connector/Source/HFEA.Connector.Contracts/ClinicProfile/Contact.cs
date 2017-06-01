using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ClinicProfile
{
    public class Contact
    {
        public int Id { get; set; }
        public int ContactTypeID { get; set; }
        public string ContactType { get; set; }
        public string Details { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
