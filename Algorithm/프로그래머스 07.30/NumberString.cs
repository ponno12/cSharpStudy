using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.프로그래머스_07._30
{
    public class Solution
    {
        public int solution(string s)
        {
            s = "one4seveneight";


            int answer = ConvertToInt(s);
            return answer;
        }
        public static int ConvertToInt(string s)
        {
            s.Replace("zero","0");
            s.Replace("one", "1");
            s.Replace("two", "2");
            s.Replace("three","3");
            s.Replace("four", "4");
            s.Replace("five", "5");
            s.Replace("six", "6");
            s.Replace("seven", "7");
            s.Replace("eight", "8");
            s.Replace("nine", "9");
            return Convert.ToInt32(s);
        }
    }
}
