using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.String
{
    public class SplitStringExample
    {
        public static void SpliteString()
        {
            // 기본적인 스플린 공백을 기준으로 스트링을 나눈다.
            string phrase = "The quick brown fox jumps over the lazy dog.";
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }

            // 문자열을 스플릿이 기준이 되는 char로 입력후 나누는 방법
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            string text = "one\ttwo three:four,five six seven";
            Console.WriteLine($"Original text: '{text}'");

            string[] words2 = text.Split(delimiterChars);
            Console.WriteLine($"{words2.Length} words in text:");

            foreach (var word in words2)
            {
                Console.WriteLine($"<{word}>");
            }

            // char뿐만 아니라 string으로도 가능
            string[] separatingStrings = { "<<", "..." };

            string text3 = "one<<two......three<four";
            System.Console.WriteLine($"Original text: '{text3}'");

            string[] words3 = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            System.Console.WriteLine($"{words3.Length} substrings in text:");

            foreach (var word in words3)
            {
                System.Console.WriteLine(word);
            }
            // Output ::
            /*Original text: 'one<<two......three<four'
            3 substrings in text:
            one
            two
            three < four*/

        }

    }
}
