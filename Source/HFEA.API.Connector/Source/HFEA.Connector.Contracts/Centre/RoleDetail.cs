using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Centre
{
   public class RoleDetail
    {
        public DateTime? EndDate { get; set; }

        public int Id { get; set; }

        public string PersonName { get; set; }

        public int RoleTypeId { get; set; }

        public DateTime? StartDate { get; set; }
    }
}
