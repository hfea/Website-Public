using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Constants
{
    public class Security
    {
        /// <summary>
        /// Note: make sure this matches SDK.Model.KnownRole
        /// </summary>
        public enum KnownRole
        {
            Unknown = 0,
            [Description("Person Responsible")]
            PR = 1,
            [Description("License Holder")]
            LicenseHolder = 2,
            [Description("Research Person Responsible")]
            ResearchPR = 4,
            [Description("User Administrator")]
            UserAdmin = 8,
            [Description("Data Entry (EDI)")]
            EdiDataEntry = 32,
            [Description("General User")]
            User = 64,
            [Description("Finance")]
            Finance = 128,
            [Description("Storage Only Person Responsible")]
            StorageOnlyPR = 256,
            [Description("IUI Only Person Responsible")]
            IuiOnlyPR = 1024,
            [Description("HFEA Admin")]
            HFEAAdmin = 2048,
            [Description("Inspector")]
            Inspector = 4096

        }

        [Flags]
        public enum UserPermission
        {
            None = 0,
            Create = 1,
            Read = 2,
            Write = 4,
            Delete = 8,
            Update = 16
        }
    }
}
