using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.프로그래머스.프로그래머스08._02
{
    // 내적
    // 길이가 같은 두 1차원 정수 배열 a, b가 매개변수로 주어집니다.
    // a와 b의 내적을 return 하도록 solution 함수를 완성해주세요.
    // 이때, a와 b의 내적은 a[0]* b[0] + a[1]* b[1] + ... + a[n - 1]* b[n - 1] 입니다.
    // (n은 a, b의 길이)
    //
    public class Solution
    {
        public int solution(int[] a, int[] b)
        {
            int answer = 0;
            a = new int[] {1,2,3,4};
            b = new int[] { -3, -1, 0, 2 };
            for (int i = 0; i < a.Length; i++)
            {
                answer += a[i] * b[i];
            }
            Console.WriteLine(answer);
            return answer;
        }

        // 프로그래머스 다른사람 풀이
        // LINQ zip명령어 미쳤다
        public int solution2(int[] a, int[] b)
        {
            return a.Zip(b, (t1, t2) => t1 * t2).Sum();
        }
    }
}
