using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.API
{
    [DataContract]
    public class ContentTag
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "val")]
        public string Value { get; set; }
    }
}
