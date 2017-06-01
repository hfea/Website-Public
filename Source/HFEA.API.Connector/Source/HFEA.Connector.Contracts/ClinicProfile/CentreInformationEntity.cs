using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.ClinicProfile
{
    public class CentreInformationEntity
    {
        public int EntityId { get; set; }
        public int EntityType { get; set; }
        public int LookupItemId { get; set; }
        public string LookupItemName { get; set; }
        public int LookupItemParentId { get; set; }
        public string LookupItemParentDescription { get; set; }
        public string DataType { get; set; }
        public bool Checked { get; set; }
        public string Text { get; set; }
        public int UpdatedBy { get; set; }

        public List<string> DataTypeList
        {
            get
            {
                return DataType.Split(' ').ToList();
            }
        }
    }
}
