using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.Grid
{
    partial class Grid
    {
        public static void Grid_3()
        {
            int[,] a = new int[3,3] { { 3, 1, 2 }, { 4, 1, 4 }, { 2, 2, 2 } };
            List<int> b = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                int temp = 100;
                for (int j = 0; j < a.Rank; j++)
                {
                    if(temp< a[i, j])
                    temp = a[i,j];
                }
                b.Add(temp);
            }
            Console.WriteLine(b.Max());
            
        }
    }
}
