using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.OnlineApps
{
    public class Application
    {
        public int Id { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationDescription { get; set; }
        public bool Active { get; set; }
        public bool? UserCreatable { get; set; }
        public int ApplicationCategoryID { get; set; }
        public string ApplicationCategory { get; set; }        
    }
}
