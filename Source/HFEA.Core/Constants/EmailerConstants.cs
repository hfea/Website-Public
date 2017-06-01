using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Core.Constants
{
    public class EmailerConstants
    {
        public const char Multiple_EmailAddresses_Seperator = ',';

        public const string Reject_Email_Recipient_Name = "%Recipient_Name%";
        public const string Reject_Email_Page_Name = "%Page_Name%";
        public const string Reject_Email_Approver_Name = "%Approver_Name%";
        public const string Reject_Email_Comment = "%Comment%";
        public const string Reject_Email_Page_Url = "%Page_Url%";
        public const string PageName = "%PageName%";
        public const string PageUrl = "%PageUrl%";
    }
}
