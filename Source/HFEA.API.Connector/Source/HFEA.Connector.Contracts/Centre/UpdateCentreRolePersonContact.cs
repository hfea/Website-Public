using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Centre
{
    public class UpdateCentreRolePersonContact
    {
        
        public string Email { get; set; }       
        public string EntityType { get; set; }      
        public string FirstName { get; set; }     
        public string LastName { get; set; }       
        public string Phone { get; set; }       
        public string RoleType { get; set; }
        public int RoleTypeId { get; set; }
    }
}
