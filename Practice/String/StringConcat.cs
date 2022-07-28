using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.String
{
    public class StringConcatExample
    {
        public static void StringConcat()
        {
            // 제일 기본적인 + += 연산자로 연결
            string userName = "<Type your name here>";
            string dateString = DateTime.Today.ToShortDateString();

            // Use the + and += operators
            string str = "Hello " + userName + ". Today is " + dateString + ".";
            System.Console.WriteLine(str);

            str += " How are you today?";
            System.Console.WriteLine(str);
            
            // 문자열 보간을 이용한 연결
            string str2 = $"Hello {userName}. Today is {dateString}.";
            System.Console.WriteLine(str);

            str = $"{str} How are you today?";
            System.Console.WriteLine(str);

            string[] words = { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog." };

            // concat과 join 문자열 사이에 값을 넣어야하면 join을 사용한다.
            var unreadablePhrase = string.Concat(words);
            System.Console.WriteLine(unreadablePhrase);

            var readablePhrase = string.Join(" ", words);
            System.Console.WriteLine(readablePhrase);

            //Linq에서도 사용가능

            var phrase = words.Aggregate((partialPhrase, word) => $"{partialPhrase} {word}");
            System.Console.WriteLine(phrase);
        }
    }
}
