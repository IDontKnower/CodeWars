// Reference: https://www.codewars.com/kata/587731fda577b3d1b0001196

using System.Globalization;
using System.Linq;

namespace CodeWars.CodeWars._6kyu
{
    public class CamelCaseKata
    {
        public static string CamelCase(string str)  
        {  
            var textInfo = new CultureInfo("en-US",false).TextInfo;
            return string.Join("", str.Split(" ").Select(x => textInfo.ToTitleCase(x)));
        }
    }
}