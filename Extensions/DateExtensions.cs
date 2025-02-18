using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DateParserDemo.Extensions
{
    public static class DateExtensions
    {
        public static DateTime ParseCustomDate(this string date)
        {
            string[] formats = { "dd-MM-yyyy", "yyyy-MM-dd HH:mm:ss" };

            if (DateTime.TryParseExact(date, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
            {
                return result;
            }

            throw new FormatException("Invalid date format: {date}");
        }
    }
}