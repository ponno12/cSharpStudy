using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    /// <summary>
    /// 배열 array의 i번째 숫자부터 j번째 숫자까지 자르고 정렬했을 때, k번째에 있는 수를 구하려 합니다.
    /// </summary>
    public class Solution
    {

        public static void Main()
        {
            int[] number = { 3, 0, 6, 1, 5 };
            Solution solution = new Solution();
            var a = solution.solution2(number);
            Console.WriteLine(a);
        }

        public int solution(int[] citations)
        {
            int answer = 0;
            List<int> list = new List<int>(citations);
            int maxcount = 0;
            list.Sort();
            answer = list[list.Count / 2];
            

            return answer;
        }

        public int solution2(int[] citations)
        {
            int answer = 0;
            Array.Sort(citations);
            Array.Reverse(citations);

            for (int i = 0; i < citations.Length; i++)
            {
                if ((i + 1) <= citations[i]) answer++;
            }
            return answer;

        }

    }
}
