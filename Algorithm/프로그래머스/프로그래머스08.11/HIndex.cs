using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.프로그래머스.프로그래머스08._10
{
    /// <summary>
    /// H-Index는 과학자의 생산성과 영향력을 나타내는 지표입니다. 어느 과학자의 H-Index를 나타내는 값인 h를 구하려고 합니다.
    /// 위키백과1에 따르면, H-Index는 다음과 같이 구합니다.
    /// 어떤 과학자가 발표한 논문 n편 중, h번 이상 인용된 논문이 h편 이상이고 나머지 논문이 h번 이하 인용되었다면 h의 최댓값이 이 과학자의 H-Index입니다.
    /// </summary>
    partial class Solution
    {

        public static void Hindex()
        {
            int[] number = { 3, 0, 6, 1, 5 };
            Solution solution = new Solution();
            var a = solution.hindex(number);
            Console.WriteLine(a);

        }

        public string solution(int[] number)
        {
            string answer = "";
            List<int> list = new List<int>(number);
            List<int> list2 = new List<int>();
            foreach (var item in list)
            {
                if (item >= 10)
                {
                    var temp = item;
                    while (temp < 10)
                    {
                        list2.Add(temp / 10);
                        temp /= 10;
                    }
                }
            }

            return answer;
        }

        public int hindex(int[] citations)
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
