using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.ViewModel.CaFC.Model
{
    public class FilterItem<T> where T : struct, IComparable<T>
    {
        public int Id { get; set; }

        public string Label { get; set; }

        public string Description { get; set; }

        public T Value { get; set; }
    }
}
