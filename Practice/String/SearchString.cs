using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.String
{
    public class SearchStringExample
    {
        // 문자열 내용 검색 예제들
        public static void SearchString()
        {
            // String의 메서드들로 찾기
            string factMessage = "Extension methods have all the capabilities of regular static methods.";

            Console.WriteLine($"\"{factMessage}\"");
            
            bool containsSearchResult = factMessage.Contains("extension");
            Console.WriteLine($"Contains \"extension\"? {containsSearchResult}");

            bool ignoreCaseSearchResult = factMessage.StartsWith("extension", System.StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine($"Starts with \"extension\"? {ignoreCaseSearchResult} (ignoring case)");

            bool endsWithSearchResult = factMessage.EndsWith(".", System.StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine($"Ends with '.'? {endsWithSearchResult}");

            // 정규화로 찾기

            // 예시 1.
            string[] sentences =
            {
                "Put the water over there.",
                "They're quite thirsty.",
                "Their water bottles broke."
            };

            string sPattern = "the(ir)?\\s";

            foreach (string s in sentences)
            {
                Console.Write($"{s,24}");

                if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    Console.WriteLine($"  (match for '{sPattern}' found)");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            // 예시 2.
            string[] numbers =
            {
                "123-555-0190",
                "444-234-22450",
                "690-555-0178",
                "146-893-232",
                "146-555-0122",
                "4007-555-0111",
                "407-555-0111",
                "407-2-5555",
                "407-555-8974",
                "407-2ab-5555",
                "690-555-8148",
                "146-893-232-"
            };

            string sPattern2 = "^\\d{3}-\\d{3}-\\d{4}$";

            foreach (string s in numbers)
            {
                Console.Write($"{s,14}");

                if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern2))
                {
                    Console.WriteLine(" - valid");
                }
                else
                {
                    Console.WriteLine(" - invalid");
                }
            }

        }
    }
}
