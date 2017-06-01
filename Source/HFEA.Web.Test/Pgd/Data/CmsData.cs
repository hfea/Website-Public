using HFEA.Connector.Contracts.CommonObjects;
using HFEA.Web.ViewModel.Constants;
using HFEA.Web.ViewModel.PGD;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Test.Pgd.Data
{
    public class CmsData
    {
        public static List<PgdItem> FullList
        {
            get
            {
                return new List<PgdItem>()
                {
                    new PgdItem() { Id = 1, DetailsUrl="/some-url-1", Name = "Condition 1 (Congenital Myasthenic Syndrome)", OMOIMM="1M", Status = PgdConstants.Status.AwaitingApproval },
                    new PgdItem() { Id = 2, DetailsUrl="/some-url-2", Name = "Condition 2", OMOIMM="2M00", Status = PgdConstants.Status.AwaitingApproval },
                    new PgdItem() { Id = 3, DetailsUrl="/some-url-1a", Name = "Condition 1A", OMOIMM="1MA", Status = PgdConstants.Status.AwaitingApproval },
                };
            }
        }        
    }
}
