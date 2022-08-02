using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.프로그래머스_07._30
{
using System;
    using System.Linq;
    using System.Collections.Generic;

    public class 음양수
    {
        public void solution(int[] numbers)
        {
            List<int> ints = new List<int>();
            int[] absolutes = new int[] { 4, 7, 12 };
            bool[] signs = new bool[] { true, false, true };

            for (int i = 0; i < absolutes.Length; i++)
            {
                if (signs[i] == true) { ints.Add(absolutes[i]); }
                else
                {
                    ints.Add(-absolutes[i]);
                }
            }
            Console.WriteLine(ints.Sum());
        }
    }
}
