// Reference: https://www.codewars.com/kata/57eb8fcdf670e99d9b000272/train/csharp

using System.Linq;

namespace CodeWars.CodeWars._6kyu
{
    public class HighestScoringWordKata
    {
        public static string High(string s)
        {
            var words = s.Split(" ");
            var maxScore = words.Select(x => x.Sum(letter => (int) letter - 96)).Max();
            var highest = words
                .Where(x => x.Sum(letter => (int) letter - 96) == maxScore)
                .ToList();
            return highest.Count == 1 ? highest.First() : words.FirstOrDefault(word => highest.Contains(word));
        }
    }
}