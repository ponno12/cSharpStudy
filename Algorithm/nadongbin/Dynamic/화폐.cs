using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.Dynamic
{
    public class 화폐
    {
        public static int Money(int[] arr, int m)
        {
            // 앞서 계산된 결과를 저장하기 위한 DP 테이블 초기화 
            int[] d = new int[m + 1];
            Array.Fill(d, 10001);

            // 다이나믹 프로그래밍(Dynamic Programming) 진행(보텀업)
            d[0] = 0;
            for (int i = 0; i < arr.Length; i++)
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
