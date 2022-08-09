using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Solution
    {
        /// <summary>
        /// 주어진 숫자 중 3개의 수를 더했을 때 소수가 되는 경우의 개수를 구하려고 합니다.
        /// 숫자들이 들어있는 배열 nums가 매개변수로 주어질 때, nums에 있는 숫자들 중 서로 다른 3개를 골라
        /// 더했을 때 소수가 되는 경우의 개수를 return 하도록 solution 함수를 완성해주세요.
        /// </summary>

        public static void Main()
        {
            int[] nums = new int[] { 1, 2, 7, 6, 4 };
            Solution s = new Solution();
            s.solution(nums);
        }
        public int solution(int[] nums)
        {
            int answer = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {

                        int sum = nums[i] + nums[j] + nums[k];

                        bool _issosu = true;
                        for (int s = 2; s < sum; s++)
                        {
                            if (sum % s == 0)
                            {
                                _issosu = false;
                            }
                        }
                        if (_issosu == true)
                            answer++;
                    }
                }
            }
            // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
            System.Console.WriteLine(answer);

            return answer;
        }
    }
}
