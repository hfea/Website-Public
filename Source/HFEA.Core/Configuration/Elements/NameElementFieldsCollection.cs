using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Core.Configuration.Elements
{
    public class NameElementFieldsCollection : FieldsCollection<NameElement>
    {
        public List<string> AllStringValues { get { return this.All.Select(x => x.Name).ToList(); } }
    }
}
