using System;
using System.Text.RegularExpressions;

namespace Kassio.Util.Text
{
    public class StringUtil
    {
        public static string GetNumbers(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;
            return Regex.Replace(value, "\\D", ""); ;
        }

        public static int ToIntOrDefault(string value)
        {
            var numbers = GetNumbers(value);
            var result = 0;
            int.TryParse(numbers, out result);
            return result;
        }

        public static string GetLetters(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;
            return Regex.Replace(value, "[^\\p{L}]", ""); ;
        }

    }

    public static class StringUtilExtension
    {
        public static string GetNumbers(this string value)
        {
            return StringUtil.GetNumbers(value);
        }

        public static int ToIntOrDefault(this string value)
        {
            return StringUtil.ToIntOrDefault(value);
        }

        public static string GetLetters(this string value)
        {
            return StringUtil.GetLetters(value);
        }
    }
}
