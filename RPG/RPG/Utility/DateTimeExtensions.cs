using System;
using System.Globalization;

namespace RPG.Utility
{
    public static class DateTimeExtensions
    {
        public static string ToCustomShortDateString(this DateTime dateTime)
        {
            return dateTime.ToString("dd / MM / yyyy");
        }

        public static string ToFormattedDate(this DateTime dateTime)
        {
            return $"{dateTime.ToShortMonthName()} {dateTime.Day}, {dateTime.Year}";
        }

        public static string ToShortMonthName(this DateTime dateTime)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(dateTime.Month);
        }
    }
}