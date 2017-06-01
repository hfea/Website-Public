using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HFEA.Connector.Contracts.ClinicProfile
{
    public class Role
    {
        public string PersonName { get; set; }
        public string ForeName { get; set; }
        public string FamilyName { get; set; }
        public int RoleTypeId { get; set; }
        public string RoleType { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
