using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.BL
{
    public static class Json
    {
        /// <summary>
        /// Get value from JSON object
        /// </summary>
        /// <param name="json">input object</param>
        /// <param name="jsonPath">path parameters</param>
        public static string GetStringValueOrEmpty(this JObject json, params string[] jsonPath)
        {
            string result = string.Empty;

            if (json != null && jsonPath != null && jsonPath.Length > 0)
            {
                JToken val = json[jsonPath[0]];

                if (val != null)
                {
                    if (jsonPath.Length == 1)
                    {
                        result = val.ToString();
                    }
                    else
                    {
                        result = val.GetStringValueOrEmpty(jsonPath.Skip(1).ToArray());
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Get value from JSON object
        /// </summary>
        /// <param name="json">input object</param>
        /// <param name="jsonPath">path parameters</param>
        public static string GetStringValueOrEmpty(this JToken jtoken, params string[] jsonPath)
        {
            string result = string.Empty;

            if (jtoken != null && jsonPath != null && jsonPath.Length > 0)
            {
                foreach (string value in jsonPath)
                {
                    if (jtoken == null)
                    {
                        break;
                    }
                    else
                    {
                        jtoken = jtoken[value];
                    }
                }

                if (jtoken != null)
                {
                    result = jtoken.ToString();
                }
            }

            return result;
        }
    }
}
