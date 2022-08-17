using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.Binary
{
    public class 떡볶이_떡
    {

        public static void 떡()
        {
            int[] array = { 19, 15, 10, 17 };
            Console.WriteLine(DDuck(array, 4, 6));
        }
        public static int DDuck(int[] array, int count, int length)
        {
            List<int> ints = array.ToList();
            int total = 0;
            int arraymin = 0;
            int arraymax = ints.Last();
            int mid = 0;
            int result = 0;
            ints.Sort();
            while (arraymin <= arraymax)
            {
                total = 0;
                mid = (arraymin + arraymax) / 2;
                foreach (var item in array)
                {
                    if (item > mid)
                        total += item - mid;
                }

                if (total < length)
                {
                    arraymax = mid - 1;
                }
                else
                {
                    result = mid;
                    arraymin = mid + 1;
                }

            }
            return result;
        }
    }
}
