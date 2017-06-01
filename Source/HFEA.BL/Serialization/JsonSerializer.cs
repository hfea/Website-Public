using HFEA.BL.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL.Serialization
{
    public class JsonSerializer : IJsonSerializer
    {
        public string Serialize<T>(T obj, bool includeObjectType = false)
        {
            var settings = new JsonSerializerSettings();
            if (includeObjectType)
            {
                // this setting is required for deserialization of interfaces
                settings.TypeNameHandling = TypeNameHandling.Objects;
                settings.Formatting = Formatting.None;
            }

            return JsonConvert.SerializeObject(obj, Formatting.Indented, settings);
        }

        public T Deserialize<T>(string s, bool includeObjectType = false)
        {
            var settings = new JsonSerializerSettings();
            if (includeObjectType)
            {
                // this setting is required for deserialization of interfaces
                settings.TypeNameHandling = TypeNameHandling.Objects;
            }

            try
            {
                return JsonConvert.DeserializeObject<T>(s, settings);
            }
            catch
            {
              // TODO: logging
               // Log.ErrorFormat("JSON Deserializer error for object {0}", typeof(T));
            }

            return default(T);
        }
    }
}
