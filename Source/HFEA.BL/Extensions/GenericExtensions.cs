using HFEA.Web.ViewModel.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL
{
    public static class GenericExtensions
    {
        public static IdValuePair ToIdValuePair(this KeyValuePair<string, string> value)
        {
            return new IdValuePair() { Id = value.Key, Value = value.Value };
        }
    }
}
