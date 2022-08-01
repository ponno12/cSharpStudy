using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.Grid
{
    public class Grid
    {
        public static void Grid_1()
        {
            int n = 1260;
            int cnt = 0;
            int[] coinTypes = new int[] { 500, 100, 50, 10 };

            foreach (var item in coinTypes)
            {
                int coin = item;
                cnt = n / coin;
                n = n % coin;
            }
            Console.WriteLine(cnt);
        }
    }
}
