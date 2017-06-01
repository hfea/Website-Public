using HFEA.Connector.Service.Attributes;
using HFEA.Connector.Service.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Service.Extensions
{
    public static class AttributeReaderExtension
    {
        public static string GetDescription(this Enum enumeration)
        {
            string result = string.Empty;
            
            var attr = GetEnumAttribute<DescriptionAttribute>(enumeration);
            if (attr != null)
            {
                result = attr.Description;
            }

            return result;
        }

        public static CallType GetCallType(this Enum enumeration)
        {
            return GetEnumAttribute<CallType>(enumeration);
        }

        private static T GetEnumAttribute<T>(Enum enumeration) where T : Attribute
        {
            var result = default(T);
            MemberInfo memberInfo = enumeration.GetType().GetMember(enumeration.ToString()).FirstOrDefault();

            if (memberInfo != null)
            {
                result = (T)memberInfo.GetCustomAttributes(typeof(T), false).FirstOrDefault();
            }

            return result;
        }

        public static T GetValueFromDescription<T>(string description)
        {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();

            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                    {
                        return (T)field.GetValue(null);
                    }
                }
            }

            throw new ArgumentException("Not found");
        }
    }
}
