using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.API
{
    [DataContract(Name = "idValuePair")]
    public class IdValuePairInt
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "val")]
        public string Value { get; set; }
    }
}
