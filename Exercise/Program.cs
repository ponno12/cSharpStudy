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
            int[] n = { 2, 3 };
            Console.WriteLine(Money(n,15));
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

        public static int MakeOne(int num)
        {
            int maxCount = 0;

            while(num > 1)
            {
                if (num % 5 == 0)
                {
                    num = num / 5;
                    maxCount++;
                }
                else if (num % 3 == 0)
                {
                    num = num / 3;
                    maxCount++;
                }
                else if (num % 2 == 0)
                {
                    num = num / 2;
                    maxCount++;
                }
                else
                {
                    num--;
                    maxCount++;
                }
            }
            
            return maxCount;
        }
       
        public static int MakeOneDynamic(int x)
        {
            int[] d = new int[30000];
            // 다이나믹 프로그래밍(Dynamic Programming) 진행(보텀업)
            for (int i = 2; i <= x; i++)
            {
                // 현재의 수에서 1을 빼는 경우
                d[i] = d[i - 1] + 1;
                // 현재의 수가 2로 나누어 떨어지는 경우
                if (i % 2 == 0)
                    d[i] = Math.Min(d[i], d[i / 2] + 1);
                // 현재의 수가 3으로 나누어 떨어지는 경우
                if (i % 3 == 0)
                    d[i] = Math.Min(d[i], d[i / 3] + 1);
                // 현재의 수가 5로 나누어 떨어지는 경우
                if (i % 5 == 0)
                    d[i] = Math.Min(d[i], d[i / 5] + 1);
            }
            return d[x];
        }        

        public static int AntWarrior(int[] x)
        {
            int[] d = new int[100];

            d[0] = x[0];
            d[1] = Math.Max(x[0], x[1]);
            for (int i = 2; i < x.Length; i++)
            {
                d[i] = Math.Max(d[i - 1], d[i - 2] + x[i]);
            }
            return d[x.Length -1];
        }
        
        public static int MakeBottom(int n)
        {
            int[] d = new int[1000];
            d[1] = 1;
            d[2] = 3;
            for (int i = 3; i <= n; i++)
            {
                d[i] = d[i - 1] + 2 * d[i - 2];
            }
            
            return d[n];
        }
        
        public static int Money(int[] arr , int m)
        {
            // 앞서 계산된 결과를 저장하기 위한 DP 테이블 초기화 
            int[] d = new int[m + 1];
            Array.Fill(d, 10001);

            // 다이나믹 프로그래밍(Dynamic Programming) 진행(보텀업)
            d[0] = 0;
            for (int i = 0; i <arr.Length; i++)
            {
                for (int j = arr[i]; j <= m; j++)
                {
                    // (i - k)원을 만드는 방법이 존재하는 경우
                    if (d[j - arr[i]] != 10001)
                    {
                        d[j] = Math.Min(d[j], d[j - arr[i]] + 1);
                    }
                }
                
            }
            if (d[m] == 10001)
                return -1;
            else
                return d[m];
        }
    }
}
