//Reference: https://www.codewars.com/kata/585d7d5adb20cf33cb000235

using System.Collections.Generic;
using System.Linq;

namespace CodeWars.CodeWars._6kyu
{
    public class GetUniqueIntKata
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            var uniqueNums = new HashSet<int>();
            foreach (var number in numbers)
            {
                if (!uniqueNums.Contains(number))
                {
                    uniqueNums.Add(number);
                }
                else
                {
                    uniqueNums.Remove(number);
                    if (uniqueNums.Count == 0) { continue; }
                    break;
                }
            }

            return uniqueNums.First();
        }
    }
}