using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.Dynamic
{
    public class 일로만들기
    {
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
    }
}
