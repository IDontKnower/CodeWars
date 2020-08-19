// Reference: https://www.codewars.com/kata/52b757663a95b11b3d00062d

using System;
using System.Globalization;
using System.Linq;

namespace CodeWars.CodeWars._6kyu
{
    public class WeirdStringCaseKata
    {
        public static string ToWeirdCase(string s)
        {
            var textInfo = new CultureInfo("en-US",false).TextInfo;
            var words = s.Split(" ");
            var list = words.Select(word =>
                word.Select((x, i) => i % 2 == 0 ? textInfo.ToUpper(x) : textInfo.ToLower(x)))
                .Select(weirdCase => String.Join("", weirdCase))
                .ToList();

            return string.Join(" ", list);
        }
    }
}