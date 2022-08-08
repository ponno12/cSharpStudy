using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Solution
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] numbers = new int[] { 1, 1, 1, 1, 1 };
            int target = 3;
            solution.solution(numbers, target);
        }
        static int Dfs(int[] arr, int target, int idx, int num)
        {
            if (idx == arr.Length)
            {
                if (target == num) return 1;
                else return 0;
            }
            else
                return Dfs(arr, target, idx + 1, num + arr[idx]) + Dfs(arr, target, idx + 1, num - arr[idx]);
        }

        public int solution(int[] numbers, int target)
        {
            int answer = 0;
            return Dfs(numbers, target, 0, 0);
        }

    }        
}
