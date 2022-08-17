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
            int[] array = { 20, 15, 10, 17 };
            Console.WriteLine(DDuck(array,4,6));
        }
        public static int DDuck(int[] array, int count, int length)
        {
            // array를 정렬하기 위해 리스트 형태로
            List<int> ints = array.ToList();
            int total; // 잘린 떡의 길이를 구하기 위한 토탈값
            ints.Sort(); // 떡 
            // 떡을 자를 칼의 범위 지정
            int arraymin = 0;
            int arraymax = ints.Last();
            int mid;
            int result = 0;
            ints.Sort();
            while (arraymin<=arraymax)
            { 
                total = 0;
                mid = (arraymin + arraymax) / 2;
                foreach (var item in array)
                {   
                    if(item > mid)
                        total += item - mid;
                }
                if(total < length)
                {
                    arraymax = mid-1;
                }
                else
                {
                    result = mid;
                    arraymin = mid+1;
                }

            }
            return result;
        }

        
       
        
    }
}
