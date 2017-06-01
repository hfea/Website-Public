using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.OnlineApps
{
    public class ApplicationDocumentControl
    {
        //
        // Summary:
        //     Control Dependency Collection
        public List<ApplicationDocumentControlDependency> ApplicationDocumentControlDependencies { get; set; }
        //
        // Summary:
        //     Application Document Control ID
        public int ApplicationDocumentControlID { get; set; }
        //
        // Summary:
        //     Category ID - not used
        public int? CategoryID { get; set; }
        //
        // Summary:
        //     If option item, what is the checked or selected value
        public string CheckedValue { get; set; }
        //
        // Summary:
        //     Child Application Document Control Collection
        public List<ApplicationDocumentControl> ChildApplicationDocumentControls { get; set; }
        //
        // Summary:
        //     Legacy html ID attribute of control
        public string ControlIDName { get; set; }
        //
        // Summary:
        //     Label of control
        public string ControlLabel { get; set; }
        //
        // Summary:
        //     Tooltip of control
        public string Tooltip { get; set; }
        //
        // Summary:
        //     Control Type ID
        public int? ControlTypeID { get; set; }
        //
        // Summary:
        //     ClassID for style
        public int? cssClassID { get; set; }
        //
        // Summary:
        //     When first rendered, what is the default value
        public string DefaultValue { get; set; }
        //
        // Summary:
        //     Template referenceID
        public int DocumentVersionID { get; set; }
        //
        // Summary:
        //     default display of control
        public bool? Enabled { get; set; }
        //
        // Summary:
        //     Is control data input mandatory
        public bool? Mandatory { get; set; }
        //
        // Summary:
        //     If true, then value has to exist in this control for next to be enabled
        public bool? NextEnable { get; set; }
        //
        // Summary:
        //     If control determines NextEnable then value of tooltip on NextButton hover
        public string NextEnableTip { get; set; }
        //
        // Summary:
        //     Page Meta Information
        public Dictionary<Constants.OnlineApps.PageMetaType, string> PageMetaInformation { get; set; }
        //
        // Summary:
        //     Parent Control
        public ApplicationDocumentControl ParentApplicationDocumentControl { get; set; }
        //
        // Summary:
        //     Sequence no of control
        public int? Sequence { get; set; }
    }
}

