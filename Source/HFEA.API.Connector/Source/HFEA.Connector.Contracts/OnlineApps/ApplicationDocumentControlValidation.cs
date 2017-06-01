using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.OnlineApps
{
    public class ApplicationDocumentControlValidation
    {
        public int DocumentControlID { get; set; }
        public string ValidationPattern { get; set; }
        public int ValidationTypeID { get; set; }
        public int ErrorLevel { get; set; }
        public string Message { get; set; }
    }
}
