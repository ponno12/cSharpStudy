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

    public class 없는숫자
    {
        public int solution(int[] numbers)
        {
            int answer = 0;
            for (int i = 0; i < 10; i++)
            {
                if (!numbers.Contains(i))
                {
                    answer += i;
                }
            }
            return answer;
        }
    }
}
