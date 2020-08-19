//Reference: https://www.codewars.com/kata/576757b1df89ecf5bd00073b

using System.Linq;

namespace CodeWars.CodeWars._6kyu
{
    public class TowerBuilderKata
    {
        private const int D = 2;

        public static string[] TowerBuilder(int nFloors)
        {
            var arr = new string[nFloors];
            for (var i = 1; i <= nFloors; i++)
            {
                var sideStarsNumber = (nFloors - i);
                arr[i - 1] = GetFloor(sideStarsNumber, i);
            }

            return arr;
        }

        private static int GetLevel(int n)
        {
            return 1 + D * (n - 1);
        }

        private static string GetFloor(int sideNum, int starNum)
        {
            var sides = string.Concat(Enumerable.Repeat(" ", sideNum));
            var starsInFloor = GetLevel(starNum);
            var stars = string.Concat(Enumerable.Repeat("*", starsInFloor));
            return sides + stars + sides;
        }
        
    }
}