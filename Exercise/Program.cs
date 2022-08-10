﻿using System;
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




        // 이렇게 할수있어야하는데 너무 길게썻다.
        // 핵심 코드는 같지만 구현줄이 너무 차이나네
        public string solution2(int[] numbers)
        {
            Array.Sort(numbers, (x, y) =>
            {
                string XY = x.ToString() + y.ToString();
                Console.WriteLine($"XY :: { XY}");
                string YX = y.ToString() + x.ToString();
                Console.WriteLine($"YX :: {YX}");
                Console.WriteLine($"YX XY Compare :: {YX.CompareTo(XY)}");

                return YX.CompareTo(XY);
            });
            if (numbers.Where(x => x == 0).Count() == numbers.Length) return "0";
            else return string.Join("", numbers);
        }
    }
}
