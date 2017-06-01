using HFEA.Connector.Global;
using log4net;
using System;

namespace HFEA.Web.Utilities
{
    public class Logger : IHfeaLogger
    {
        private readonly ILog logger;

        public Logger()
        {
            this.logger = LogManager.GetLogger("HFEA");
        }

        public void Info(object message)
        {
            this.logger.Info(message);
        }
        public void Warning(object message)
        {
            this.logger.Warn(message);
        }

        public void Warning(object message, Exception exception)
        {
            this.logger.Warn(message, exception);
        }

        public void Error(object message, Exception exception)
        {
            this.logger.Error(message, exception);
        }

        public void Fatal(object message)
        {
            this.logger.Fatal(message);
        }
    }
}
