using HFEA.Web.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HFEA.Web
{
    public static class WebExtensions
    {
        public static string GetQryParamValueOrNull(this QueryString.QueryParams param)
        {
            return HttpContext.Current.Request[param.ToString()];
        }

        public static bool TryGetQryParamValueAsEnum<TEnum>(this QueryString.QueryParams param, out TEnum result) where TEnum : struct
        {
            bool success = false;
            result = default(TEnum);

            var value = param.GetQryParamValueOrNull();
            success = Enum.TryParse<TEnum>(value, out result);

            return success;
        }

        public static bool TryGetQryParamValue<T>(this QueryString.QueryParams param, out T result) where T : struct
        {
            bool success = false;
            result = default(T);

            var value = param.GetQryParamValueOrNull();
            if (!string.IsNullOrEmpty(value))
            {
                try
                {
                    result = (T)Convert.ChangeType(value.ToString(), typeof(T));
                    success = true;
                }
                catch { }
            }

            return success;
        }

        public static T GetQryParamValueOrDefault<T>(this QueryString.QueryParams param, T defaultValue) where T : struct
        {
            T result = defaultValue;

            var value = param.GetQryParamValueOrNull();
            if (!string.IsNullOrEmpty(value))
            {
                try
                {
                    result = (T)Convert.ChangeType(value.ToString(), typeof(T));
                }
                catch { }
            }

            return result;
        }

        public static bool QueryExistsAndEquals(this QueryString.QueryParams param, QueryString.QueryValues value)
        {
            bool result = false;

            var val = param.GetQryParamValueOrNull();
            result = !string.IsNullOrEmpty(val) && string.Equals(val, value.ToString(), StringComparison.InvariantCultureIgnoreCase);

            return result;
        }

        public static bool QueryExistsAndEquals(this QueryString.QueryParams param, string compareValue, bool ignoreCase = true)
        {
            bool result = false;

            var value = param.GetQryParamValueOrNull();
            result = !string.IsNullOrEmpty(value) && string.Equals(value, compareValue, ignoreCase ? StringComparison.InvariantCultureIgnoreCase : StringComparison.CurrentCulture);

            return result;
        }
    }
}
