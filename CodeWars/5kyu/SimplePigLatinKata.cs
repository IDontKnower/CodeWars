// Reference: https://www.codewars.com/kata/520b9d2ad5c005041100000f

using System;
using System.Linq;

namespace CodeWars.CodeWars._5kyu
{
    public class SimplePigLatinKata
    {
        public static string PigIt(string str)
        {
            return String.Join(' ',
                str.Split(" ")
                    .Select(word => word.Substring(1) + word.Substring(0, 1) + "ay")
                );
        }
    }
}