using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Users
{
    public class SecurityRole
    {
        public string DisplayName { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [Obsolete("same as KnownName, but some API calls require this property, for example /security/users/me")]
        public Constants.Security.KnownRole Name { get; set; }

        public Constants.Security.KnownRole KnownName { get; set; }
    }
}
