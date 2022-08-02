using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Solution
    {
        public static void Main()
        {
            Grid_5();

        }
        public static void Grid_1()
        {
            int n = 1260;
            int cnt = 0;
            int[] coinTypes = new int[] { 500, 100, 50, 10 };

            foreach (var item in coinTypes)
            {
                int coin = item;
                cnt += n / coin;
                n = n % coin;
            }
            Console.WriteLine(cnt);
        }
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
                    result += v[n-2];
                else
                    result += v[n-1];
            }
            Console.WriteLine(result);

        }
        public static void Grid_3()
        {
            int[,] a = new int[3, 3] { { 3, 1, 2 }, { 4, 1, 4 }, { 2, 2, 2 } };
            List<int> b = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                int temp = 100;
                for (int j = 0; j < a.Rank; j++)
                {
                    if (temp > a[i, j])
                        temp = a[i, j];
                }
                b.Add(temp);
            }
            Console.WriteLine(b.Max());
            b.Clear();
            int[] ints;
            foreach (var item in a)
            {
                
            }

        }
        public static void Grid_4()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int K = Convert.ToInt32(Console.ReadLine());
            int answer = 0;
            while (N != 1)
            {
                if (N % K != 0) {
                N -= 1; answer++;
                }
                else {
                    answer++; N /= K;
                }
                    

            }

            Console.WriteLine(answer);
        }
        public static void Grid_5()
        {
            string a = "02984";
            char[] c = a.ToCharArray();

            int result = 0;
            foreach (var item in c)
            {
                if (item == '0' || result == 0)
                {
                    result += (int)Char.GetNumericValue(item);
                    
                }
                else
                {
                    result *= (int)Char.GetNumericValue(item);
                }
            }
            Console.WriteLine(result);

        }
    }
}
