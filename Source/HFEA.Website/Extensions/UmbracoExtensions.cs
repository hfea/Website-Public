using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbraco.interfaces;
using umbraco.NodeFactory;

namespace HFEA.Web
{
    public static class UmbracoExtensions
    {
        public static int? GetFirstChildIdByDocType(this INode node, string doctype)
        {
            return node.GetFirstChildByDocType(doctype)?.Id;
        }

        public static INode GetFirstChildByDocType(this INode node, string doctype)
        {
            if (node != null && node.Id > 0 && node.ChildrenAsList != null)
            {
                return node.ChildrenAsList.FirstOrDefault(x => x.NodeTypeAlias == doctype);
            }

            return null;
        }
    }
}
