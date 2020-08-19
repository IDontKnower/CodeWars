// Reference: https://www.codewars.com/kata/57814d79a56c88e3e0000786

using System.Collections.Generic;
using System.Linq;

namespace CodeWars.CodeWars._6kyu
{
    public class AlternatingSplitKata
    {
        public static string Encrypt(string text, int n)
        {
            if (string.IsNullOrWhiteSpace(text) || n <= 0)
            {
                return text;
            }
            var encryptedText = text;
            for(var i = 1; i <= n; i++)
            {
                encryptedText = EncryptFunction(encryptedText);
            }
            return encryptedText;
        }
        
        public static string Decrypt(string encryptedText, int n)
        {
            if (string.IsNullOrWhiteSpace(encryptedText) || n <= 0)
            {
                return encryptedText;
            }
            var number = (int) (encryptedText.Length / 2);
            var text = encryptedText;
            
            for(var i = 1; i <= n; i++)
            {
                var seconds = text.Substring(0, number);
                var others = text.Substring(number);
                text = DecryptFunction(others, seconds);
            }
            return text;
        }

        private static string EncryptFunction(string text)
        {
            var even = new Queue<char>();
            var odd = new Queue<char>();
            for (var i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even.Enqueue(text[i]);
                    continue;
                }
                odd.Enqueue(text[i]);
            }

            return EnumToString(odd) + EnumToString(even);
        }
        
        private static string DecryptFunction(string others, string seconds)
        {
            var result = "";
            if (seconds.Length == others.Length)
            {
                for (var i = 0; i < others.Length; i++)
                {
                    result = result + others[i] + seconds[i];
                }
            }
            else
            {
                for (var i = 0; i < seconds.Length; i++)
                {
                    result = result + others[i] + seconds[i];
                }

                result = result + others[^1];
            }

            return result;
        }

        private static string EnumToString(IEnumerable<char> array)
        {
            return string.Join("", array.ToArray());
        }
    }
}