using System;
using System.Collections.Generic;

namespace CodeWars.CodeWars._6kyu
{
    public class ValidBracesKata
    {
        public static bool ValidBraces(string braces)
        {
            try
            {
                var openBraces = new HashSet<char>{'(', '[', '{'};
                var braceDict = new Dictionary<char, char>
                {
                    [')'] = '(', 
                    [']'] = '[', 
                    ['}'] = '{'
                };
                var stack = new Stack<char>();

                foreach (var brace in braces)
                {
                    if (openBraces.Contains(brace))
                    {
                        stack.Push(brace);
                        continue;
                    }

                    var stackBrace = stack.Pop();
                    if (!stackBrace.Equals(braceDict[brace]))
                    {
                        return false;
                    }
                }

                return stack.Count == 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}