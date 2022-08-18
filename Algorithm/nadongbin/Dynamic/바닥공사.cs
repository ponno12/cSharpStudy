using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.Dynamic
{
    internal class 바닥공사
    {
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
    }
}
