using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.Implement
{
    partial class Implement
    {
        public static void Implement_4()
        {
            string a = Console.ReadLine();
            char[] chars = a.ToCharArray();

            List<int> listInt = new List<int>();
            List<char> listchar = new List<char>();
            foreach (var item in chars)
            {
                if (Char.IsLetter(item))
                {
                    listchar.Add(item);
                }
                else if (Char.IsDigit(item))
                {
                    listInt.Add((int)Char.GetNumericValue(item));
                }
            }
            listchar.Sort();
            string answerString = new string(listchar.ToArray());
            int answerInt = listInt.Sum();
            Console.WriteLine(answerString + answerInt.ToString());
            Console.WriteLine(answerInt);

        }

    }
}
