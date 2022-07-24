using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            //make 1
            string k = Console.ReadLine();
            string m = Console.ReadLine();

            Console.WriteLine($"{k} , {m}");
            int k1 = Convert.ToInt32(k);
            int m1 = Convert.ToInt32(m); ;
            int n = Convert.ToInt32(k);
            int k2 = Convert.ToInt32(m); ;
            int count = 0;
            int result = 0;


            while (true)
            {
                // N이 K로 나누어 떨어지는 수가 될 때까지만 1씩 빼기
                int target = (n / k2) * k2;
                result += (n - target);
                n = target;
                // N이 K보다 작을 때 (더 이상 나눌 수 없을 때) 반복문 탈출
                if (n < k2) break;
                // K로 나누기
                result += 1;
                n /= k2;
            }
/*
            do
            {
                if(k1%m1 != 0)
                {
                    k1--;
                    count++;
                }
                else
                {
                    k1 /= m1;
                    count++;
                }

            } while (k1 !=1);
*/
            Console.WriteLine(count);
            Console.WriteLine(result);
        }
        
    }
}
