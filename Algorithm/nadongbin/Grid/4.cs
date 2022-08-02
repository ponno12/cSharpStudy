using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.Grid
{
    partial class Grid
    {
        public static void Grid_4()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int K = Convert.ToInt32(Console.ReadLine());
            int answer = 0;


            while (N != 1)
            {
                if (N % K == 0)
                { answer++; N /= K; }
                else
                    N -= 1; answer++;

            }

            Console.WriteLine(answer);
        }
    }
}
