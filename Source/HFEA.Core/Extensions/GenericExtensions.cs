using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;

namespace HFEA
{
    public static class TypeConversionExtensions
    {
        private const string ShortDateFormat = "dd/MM/yyyy";
        private const string DisplayShortDateTimeFormat = "dd/MM/yyyy hh:ss";
        private const string DisplayShortDateFormat = "d MMMM yyyy";
        
        /// <summary>
        /// Convert string to enum value
        /// </summary>
        /// <typeparam name="T">T must be an enumeration</typeparam>
        public static T ToEnumValue<T>(this string value) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }

            if (!string.IsNullOrEmpty(value))
            {
                foreach (T item in Enum.GetValues(typeof(T)))
                {
                    if (item.ToString().ToLower().Equals(value.Trim().ToLower())) return item;
                }
            }

            return default(T);
        }

        public static int? ToNullableInt(this string value)
        {
            int? result = null;

            int tmp;
            if (int.TryParse(value, out tmp))
            {
                result = tmp;
            }

            return result;
        }

        /// <summary>
        /// Converts a date string into format dd/MM/yyyy
        /// </summary>
        public static string ToHFEAShortDateString(this DateTime date)
        {
            return date.ToString(ShortDateFormat);
        }

        /// <summary>
        /// Converts a date string into format d MMMM yyyy
        /// </summary>
        public static string ToHFEADisplayShortDateString(this DateTime date)
        {
            return date.ToString(DisplayShortDateFormat);
        }

        /// <summary>
        /// Converts a date string into format dd/MM/yyyy, otherwise returns EMPTY
        /// </summary>
        public static string ToHFEAShortDateStringOrEmpty(this DateTime? date)
        {
            if (date != null)
            {
                return date.Value.ToHFEAShortDateString();
            }

            return string.Empty;
        }

        /// <summary>
        /// Converts a date string into format dd/MM/yyyy hh:ss, otherwise returns EMPTY
        /// </summary>
        public static string ToHFEADateTimeStringOrEmpty(this DateTime? date)
        {
            if (date != null)
            {
                return date.Value.ToHFEADateTimeString();
            }

            return string.Empty;
        }

        public static string ToHFEADateTimeString(this DateTime date)
        {
            return date.ToString(DisplayShortDateTimeFormat);
        }

        /// <summary>
        /// Converts a date string into format d MMMM yyyy, otherwise returns EMPTY
        /// </summary>
        public static string ToHFEADisplayShortDateStringOrEmpty(this DateTime? date)
        {
            if (date != null)
            {
                return date.Value.ToHFEADisplayShortDateString();
            }

            return string.Empty;
        }

        public static string ToHFEADisplayShortDateStringOrDefault(this DateTime? date, string defaultValue)
        {
            if (date != null)
            {
                return date.Value.ToHFEADisplayShortDateString();
            }

            return defaultValue;
        }

        /// <summary>
        /// Accepted formats are ISO (yyyy-MM-ddTHH:mm:ss) and US (M/d/yyyy hh:mm:ss tt) dates
        /// </summary>
        /// <param name="date">date string</param>
        /// <returns></returns>
        public static DateTime? ToNullableDate(this string date)
        {
            DateTime? result = null;

            string[] formats = new string[]
                {
                    @"yyyy-MM-dd\THH:mm:ss\Z",
                    @"yyyy-MM-dd\THH:mm:ss.FFF\Z",
                    @"M/d/yyyy hh:mm:ss tt",
                    "s"
                };

            DateTime tmp;
            if (DateTime.TryParseExact(date, formats, null, DateTimeStyles.AllowWhiteSpaces, out tmp))
            {
                result = tmp;
            }

            return result;
        }

        public static DateTime ToDateFromIsoString(this string date)
        {
            DateTime result = DateTime.MinValue;

            var value = date.ToNullableDate();
            if (value != null)
            {
                result = value.Value;
            }

            return result;
        }

        public static string ToHFEAShortDateStringOrEmpty(this string date)
        {
            return date.ToNullableDate().ToHFEAShortDateStringOrEmpty();
        }

        public static string ToShortDateStringFromIsoString(this string date)
        {
            DateTime dateTime = date.ToDateFromIsoString();
            return dateTime.ToHFEAShortDateString();
        }

        public static string GetDescriptionOrStringValue(this Enum enumeration)
        {
            Type type = enumeration.GetType();

            MemberInfo[] memInfo = type.GetMember(enumeration.ToString());

            object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attrs != null && attrs.Length > 0)
            {
                return ((DescriptionAttribute)attrs[0]).Description;
            }

            return enumeration.ToString();
        }

        public static bool ContainsIgnoreCase(this string value, string contains)
        {
            return value == null || contains == null
                ? false
                : value.ToUpper().Contains(contains.ToUpper());
        }

        public static string AntiXssEncode(this string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                value = System.Web.Security.AntiXss.AntiXssEncoder.HtmlEncode(value, true);
            }

            return value;
        }
    }
}
