using Autofac;
using Autofac.Extras.CommonServiceLocator;
using HFEA.Connector.Global;
using HFEA.Connector.Test.Services;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Test
{
    public class IocInit
    {
        public static void Init()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConfigService>().As<IConfigValues>();
            builder.RegisterType<Logger>().As<IHfeaLogger>();
                       
            var container = builder.Build();

            // Set the service locator to an AutofacServiceLocator.
            var csl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => csl);            
        }
    }
}
