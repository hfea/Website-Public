using HFEA.Connector.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Test.Services
{
    public class Logger : IHfeaLogger
    {
        public void Error(object message, Exception exception)
        {  
            /// Do nothing?          
        }

        public void Fatal(object message)
        {
            /// Do nothing? 
        }

        public void Info(object message)
        {
            /// Do nothing? 
        }

        public void Warning(object message)
        {
            /// Do nothing? 
        }

        public void Warning(object message, Exception exception)
        {
            /// Do nothing? 
        }
    }
}
