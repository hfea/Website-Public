using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Service.Extensions
{
    public static class MappingExtensions
    {
        public static bool IsEqualRole(this SDK.Model.KnownRole role1, Contracts.Constants.Security.KnownRole role2)
        {
            return (int)role1 == (int)role2;
        }
    }
}
