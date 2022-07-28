using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.String
{
    public class ModifyStringExample
    {
        public static void ModifyString()
        {
            // 문자열 바꾸기
            string source = "The mountains are behind the clouds today.";

            var replacement = source.Replace("mountains", "peaks");
            Console.WriteLine($"The source string is <{source}>");
            Console.WriteLine($"The updated string is <{replacement}>");

            // 문자열 공백제거
            // Remove trailing and leading white space.
            string source2 = "    I'm wider than I need to be.      ";
            // Store the results in a new string variable.
            var trimmedResult = source2.Trim();
            var trimLeading = source2.TrimStart();
            var trimTrailing = source2.TrimEnd();
            Console.WriteLine($"<{source2}>");
            Console.WriteLine($"<{trimmedResult}>");
            Console.WriteLine($"<{trimLeading}>");
            Console.WriteLine($"<{trimTrailing}>");

            // 텍스트 제거
            string source3 = "Many mountains are behind many clouds today.";
            // Remove a substring from the middle of the string.
            string toRemove = "many ";
            string result = string.Empty;
            int i = source.IndexOf(toRemove);
            if (i >= 0)
            {
                result = source.Remove(i, toRemove.Length);
            }
            Console.WriteLine(source);
            Console.WriteLine(result);

            // 개별 문자
            string phrase = "The quick brown fox jumps over the fence";
            Console.WriteLine(phrase);

            char[] phraseAsChars = phrase.ToCharArray();
            int animalIndex = phrase.IndexOf("fox");
            if (animalIndex != -1)
            {
                phraseAsChars[animalIndex++] = 'c';
                phraseAsChars[animalIndex++] = 'a';
                phraseAsChars[animalIndex] = 't';
            }

            string updatedPhrase = new string(phraseAsChars);
            Console.WriteLine(updatedPhrase);

        }
    }
}
