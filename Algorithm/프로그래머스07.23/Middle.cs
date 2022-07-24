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
            string s = "abcdef";
            string r = Middle(s).Replace(" " , "");

            Console.WriteLine(r);
        }
        public static string Middle(string s)
        {
            char[] result = new char[s.Length];
            string r = "";
            if(s.Length%2 == 0)
            {
                result[0] = s[s.Length/ 2 -1];
                result[1] = s[s.Length /2 ];

            }
            else if(s.Length%2 == 1)
            {
                result[0] = s[s.Length / 2];
            }
            for (int i = 0; i < result.Length; i++)
            {
                r += result[i];

            }
            
            return r;
        }
    }
}
