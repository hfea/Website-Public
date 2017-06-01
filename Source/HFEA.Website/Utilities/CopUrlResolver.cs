using HFEA.Web.ViewModel.COP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Web.ViewModel;
using umbraco.NodeFactory;
using HFEA.Core;

namespace HFEA.Web.Utilities
{
    public class CopUrlResolver : ICOPUrlResolver
    {
        public string GetSectionLink(int sectionId)
        {
            string result = string.Empty;

            if (sectionId > 0)
            {
                var node = new Node(Core.Config.Settings.KeyPages.CodeOfPractice);

                if (node != null && node.Id != 0)
                {
                    result = node.NiceUrl + sectionId;
                }
            }

            return result;
        }
    }
}
