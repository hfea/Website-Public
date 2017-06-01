using HFEA.Core.Extensions;
using HFEA.Web.ViewModel.PGD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbraco.NodeFactory;

namespace HFEA.Web.Utilities
{
    public class PgdConditionsCmsReader : IPgdConditionsCmsReader
    {
        private const string OmoimmField = "oMOIMMNumber";
        private const string NameField = "pageTitle";

        public List<PgdItem> GetAllConditionByListingPageId(int listingPageId)
        {
            List<PgdItem> result = null;

            if (listingPageId > 0)
            {
                var node = new Node(listingPageId);
                if (node != null && node.Id > 0 && node.Children != null)
                {
                    var children = node.ChildrenAsList
                        .Where(x => x.NodeTypeAlias == Core.Config.Settings.KeyDocTypes.PgdDetails);

                    if (!children.IsNullOrEmpty())
                    {
                        result = children.Select(x => new PgdItem() {
                            Id = x.Id,
                            Status = ViewModel.Constants.PgdConstants.Status.AwaitingApproval,
                            DetailsUrl = x.Url,
                            Name = x.GetProperty(NameField)?.Value,
                            OMOIMM = x.GetProperty(OmoimmField)?.Value,
                        }).ToList();
                    }
                }
            }

            return result;
        }
    }
}
