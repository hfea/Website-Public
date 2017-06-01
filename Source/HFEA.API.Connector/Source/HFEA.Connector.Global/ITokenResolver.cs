using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Global
{
    public interface ITokenResolver
    {
        string GetJwtToken();
    }
}
