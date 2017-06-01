using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Core.Constants
{
    public class UmbracoConstants
    {
        public static List<string> ContentChangeApproverUserTypes = new List<string>() { "admin", "SiteAdministrator", "editor" };
        public const string ContentEditUrl = "/umbraco/#/content/content/edit/";
    }
}
