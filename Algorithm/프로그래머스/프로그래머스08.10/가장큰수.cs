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
    /// <summary>
    /// 배열 array의 i번째 숫자부터 j번째 숫자까지 자르고 정렬했을 때, k번째에 있는 수를 구하려 합니다.
    /// </summary>
    partial class Solution
    {

        public static void 가장큰수()
        {
            int[] number = { 3, 30, 34, 5, 9 };
            Solution solution = new Solution();
            var a = solution.solution2(number);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
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




        // sort에서 어떤식으로 정렬하는지는 알수없지만 조건은 명시할수있음
        // -1시 안바꿈 +1시 바꿈을 람다 조건으로 넣어서 정리한다.
        public string solution2(int[] numbers)
        {
            Array.Sort(numbers, (x, y) =>
            {
                string XY = x.ToString() + y.ToString();
                string YX = y.ToString() + x.ToString();
                return YX.CompareTo(XY);
            });

            if (numbers.Where(x => x == 0).Count() == numbers.Length) return "0";
            else return string.Join("", numbers);
        }
    }
}
