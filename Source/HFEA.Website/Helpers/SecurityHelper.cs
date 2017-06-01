using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Helpers
{
    public class SecurityHelper
    {
        private const string Secret = @"somesecretstring";

        public static string GetHashedString(string value, string additionalParameter)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(additionalParameter))
            {
                string composed = value + "-" + additionalParameter + "-" + Secret;
                byte[] dataArray = UTF8Encoding.UTF8.GetBytes(composed);

                var sha = new SHA1CryptoServiceProvider();
                byte[] hashBytes = sha.ComputeHash(dataArray);

                result = System.Web.HttpUtility.UrlEncode(Convert.ToBase64String(hashBytes));
            }

            return result;
        }

        public static bool IsValidHash(string value, string additionalParameter, string hash)
        {
            string calcHash = System.Web.HttpUtility.UrlDecode(GetHashedString(value, additionalParameter));

            return !string.IsNullOrEmpty(hash) && string.Equals(calcHash, hash);
        }
    }
}
