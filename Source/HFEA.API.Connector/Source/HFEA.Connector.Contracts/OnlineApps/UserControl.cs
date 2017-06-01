using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.OnlineApps
{
    public class UserControl
    {
        public List<UserControl> ChildControls { get; set; }
        public string ControlID { get; set; }
        public string ControlValue { get; set; }
    }
}
