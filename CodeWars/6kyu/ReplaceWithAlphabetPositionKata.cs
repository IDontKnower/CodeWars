//Reference: https://www.codewars.com/kata/546f922b54af40e1e90001da

using System.Linq;

namespace CodeWars.CodeWars._6kyu
{
    public class ReplaceWithAlphabetPositionKata
    {
        public static string AlphabetPosition(string text)
        {
            var lowerText = text.ToLower();
            var list = (from letter in lowerText where char.IsLetter(letter) select (int) letter - 96).ToList();
            return string.Join(" ", list);
        }
    }
}