using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Users
{
    public class User
    {
        [JsonProperty("centreId")]
        public string CentreId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
   
        public string EmailAddress { get; set; }
       
        public string FirstName { get; set; }
   
        public string Id { get; set; }

        [JsonProperty("enabled")]
        public bool IsEnabled { get; set; }
   
        public string LastName { get; set; }

        public string PrincipalName { get; set; }

        public List<SecurityRole> Roles { get; set; }
    }
}
