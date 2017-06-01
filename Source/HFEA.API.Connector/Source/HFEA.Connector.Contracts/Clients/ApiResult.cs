using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Client
{
    public class ApiResult<T> where T : new()
    {
        public ApiResult(HttpStatusCode statusCode, string reason)
        {
            this.ResponseStatusCode = statusCode;
            this.ResponseReason = reason;
        }

        public T Result { get; set; }

        public bool IsSuccess { get; set; }

        public HttpStatusCode ResponseStatusCode { get; private set; }

        public string ResponseReason { get; private set; }
    }
}
