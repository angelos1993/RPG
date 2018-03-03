using System;
using static System.Globalization.CultureInfo;

namespace RBG.Utility
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
            return CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(dateTime.Month);
        }
    }
}