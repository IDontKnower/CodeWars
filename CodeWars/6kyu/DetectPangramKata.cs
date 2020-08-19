//Reference: https://www.codewars.com/kata/545cedaa9943f7fe7b000048

using System.Collections.Generic;
using System.Linq;

namespace CodeWars.CodeWars._6kyu
{
    public class DetectPangramKata
    {
        public static bool IsPangram(string str)
        {
            var lettersIndex = new HashSet<int>(Enumerable.Range(1, 26));
            var lowerString = str.Replace(" ", "").ToLower();
            foreach (var letter in lowerString.Where(letter => lettersIndex.Contains((int) letter - 96)))
            {
                lettersIndex.Remove((int) letter - 96);
            }

            return lettersIndex.Count == 0;
        }
    }
}