using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace RBG.Utility
{
    public static class StringExtensions
    {
        public static string FullTrim(this string str)
        {
            return Regex.Replace(str.TrimStart().TrimEnd().Trim(), @"\s+", " ");
        }

        public static bool IsNullOrEmptyOrWhiteSpace(this string str)
        {
            return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
        }

        public static string ToMd5Hash(this string str)
        {
            var stringBuilder = new StringBuilder();
            foreach (var t in MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(str)))
                stringBuilder.Append(t.ToString("X2"));
            return stringBuilder.ToString();
        }
    }
}