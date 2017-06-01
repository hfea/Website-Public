using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Helpers
{
    public class TextHelpers
    {
        public static string GetSingularOrPluralLabel(int number, string singular, string plural)
        {
            return GetSingularOrPluralLabel(number, string.Empty, singular, plural);
        }

        public static string GetSingularOrPluralLabel(int number, string empty, string singular, string plural)
        {
            if (number < 1) return empty;
            
            string formatting =  number == 1 ? singular : plural;

            return string.Format(formatting, number);
        }
    }
}
