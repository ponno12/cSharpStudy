using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.Grid
{
    partial class Grid
    {
        public static void Grid_5()
        {
            string a = "02984";
            char[] c = a.ToCharArray();

            int result = 0;
            foreach (var item in c)
            {
                if (item == '0' || result ==0)
                {
                    result += Convert.ToInt32(item);
                }
                else
                {
                    result *= Convert.ToInt32(item);
                }
            }
            Console.WriteLine(result);

        }
    }
}
