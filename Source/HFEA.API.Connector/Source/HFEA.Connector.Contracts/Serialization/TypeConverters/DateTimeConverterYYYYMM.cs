using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Serialization.TypeConverters
{
    public class DateTimeConverterYYYYMM : IsoDateTimeConverter
    {
        public DateTimeConverterYYYYMM()
        {
            base.DateTimeFormat = "yyyyMM";
        }
    }
}
