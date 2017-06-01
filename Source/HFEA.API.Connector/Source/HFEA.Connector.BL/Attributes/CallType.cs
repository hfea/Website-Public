using HFEA.Connector.Service.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Service.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class CallType : Attribute
    {
        public HttpMethod Method { get; private set; }
        public bool RequiresAuthentication { get; private set; }

        public CallType (HttpMethod method, bool requiresAuthentication)
        {
            this.Method = method;
            this.RequiresAuthentication = requiresAuthentication;
        }
    }
}
