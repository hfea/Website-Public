using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Global
{
    public interface IHfeaLogger
    {
        void Error(object message, Exception exception);
        void Fatal(object message);
        void Info(object message);
        void Warning(object message);
        void Warning(object message, Exception exception);
    }
}
