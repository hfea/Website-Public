using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Constants
{
    public class OnlineApps
    {
        public enum DependencyType
        {
            Unknown = 0,

            [Description("Enables a group  of controls and disables other referenced groups")]
            ToggleEnable,

            [Description("Disables a group  of controls and enables other referenced groups")]
            ToggleDisable,

            [Description("Enables a control group")]
            Enable,

            [Description("Disables a control group")]
            Disable,

            [Description("Indicates a page dependency")]
            PageEnable,

            Clone
        }

        public enum PageMetaType
        {
            Unknown = 0,
            Progress,
            Submit,
            SubmitEnable,
            PreviousReadOnly,
            Previous,
            NextReadOnly,                        
            Next,
            Save,
            Close,
            NextButtonToolTip,
            Print
        }        
    }
}
