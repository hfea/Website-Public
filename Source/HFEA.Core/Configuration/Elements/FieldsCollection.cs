using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Core.Configuration.Elements
{
    public class FieldsCollection<T> : ConfigurationElementCollection where T : ConfigurationElement, new()
    {
        public List<T> All { get { return this.Cast<T>().ToList(); } }

        public T this[int index]
        {
            get
            {
                return base.BaseGet(index) as T;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new T();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (T)element;
        }
    }
}
