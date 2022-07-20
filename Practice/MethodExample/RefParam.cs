using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MethodExample
{
    public class ParamsExample
    {
        public static void Param()
        {
            string fromArray = GetVowels(new[] { "apple", "banana", "pear" });
            Console.WriteLine($"Vowels from array: '{fromArray}'");

            string fromMultipleArguments = GetVowels("apple", "banana", "pear");
            Console.WriteLine($"Vowels from multiple arguments: '{fromMultipleArguments}'");

            string fromNull = GetVowels(null);
            Console.WriteLine($"Vowels from null: '{fromNull}'");

            string fromNoValue = GetVowels();
            Console.WriteLine($"Vowels from no value: '{fromNoValue}'");
        }

        static string GetVowels(params string[] input)
        {
            if (input == null || input.Length == 0)
            {
                return string.Empty;
            }

            var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            return string.Concat(
                input.SelectMany(
                    word => word.Where(letter => vowels.Contains(char.ToUpper(letter)))));
        }
    }

    // The example displays the following output:
    //     Vowels from array: 'aeaaaea'
    //     Vowels from multiple arguments: 'aeaaaea'
    //     Vowels from null: ''
    //     Vowels from no value: ''
}
