using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.Grid
{
    partial class Grid
    {
        public static void Grid_2()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n}, {m} ,{k}");
            int result = 0;

            List<int> v = new List<int>();
            for (int i = 0; i < n; i++)
            {
                v.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine(v[i]);
            }
            v.Sort();
            for (int i = 0; i < m; i++)
            {
                if (i == 0)
                    result += v[n - 1];
                else if (i % k == 0)
                    result += v[n - 2];
                else
                    result += v[n - 1];
            }
            Console.WriteLine(result);

        }
    }
}
