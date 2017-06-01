using HFEA.Connector.Contracts.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Centre
{
    public class PermissionMatrix
    {
        public Dictionary<string, Security.UserPermission> DataBlockPermission { get; set; }
    }
}
