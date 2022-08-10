using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.프로그래머스.프로그래머스08._10
{
    /// <summary>
    /// 0 또는 양의 정수가 주어졌을 때, 정수를 이어 붙여 만들 수 있는 가장 큰 수를 알아내 주세요.
    /// </summary>
    public class Solution
    {

        public static void Main()
        {
            int[] array = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
            Solution solution = new Solution();
            int[] a = solution.solution(array, commands);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }

        public int[] solution(int[] array, int[,] commands)
        {

            int[] answer = new int[commands.GetLength(0)];


            for (int i = 0; i < commands.GetLength(0); i++)
            {
                // 2
                int first = commands[i, 0];
                // 5
                int last = commands[i, 1];
                // 7
                List<int> temp = new List<int>();
                // 4번 반복
                for (int j = 0; j <= last - first; j++)
                {
                    temp.Add(array[j + first - 1]);

                }
                List<int> list = temp;
                list.Sort();
                int answerinsert = commands[i, 2];
                answer[i] = list[answerinsert - 1];
            }
            return answer;
        }

        // 이렇게 할수있어야하는데 너무 길게썻다.
        // 핵심 코드는 같지만 구현줄이 너무 차이나네
        public int[] solution2(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];
            List<int> lst = new List<int>(array);
            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int nStart = commands[i, 0];
                int nEnd = commands[i, 1];
                int nIndex = commands[i, 2];
                List<int> lstSub = lst.Where((x, idx) => idx >= nStart - 1 && idx < nEnd).OrderBy(x => x).ToList();
                answer[i] = lstSub[nIndex - 1];
            }
            return answer;
        }
    }
}
