using System;

namespace RBG.Utility
{
    public static class DateTimeExtensions
    {
        public static string ToCustomShortDateString(this DateTime dateTime)
        {
            return dateTime.ToString("dd / MM / yyyy");
        }
    }
}