using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            string[] seoul = { "Jane", "Kim" };
            int x = 0;
            int i = 0;
            for (i = 0; i < seoul.Length; i++)
            {
                if (seoul[i] == "Kim")
                    x = i;
            }

            string answer = $"김서방은 {x}에 있다";
            Console.WriteLine(answer);
        }
    }
}
