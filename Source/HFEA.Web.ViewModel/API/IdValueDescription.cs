using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.API
{
    [DataContract(Name = "idValueDesc")]
    public class IdValueDescription : IdValuePair
    {
        [DataMember(Name = "desc")]
        public string Description { get; set; }
    }
}
