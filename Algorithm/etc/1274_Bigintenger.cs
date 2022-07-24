using System;
using System.Collections;
using System.Numerics;
namespace Algorithm.etc
{
    class boj1274
    {
        public static void Bigintenger1274()
        {
            string input = Console.ReadLine();
            string[] spt = input.Split(' ');
            BigInteger n = BigInteger.Parse(spt[0]);
            BigInteger m = BigInteger.Parse(spt[1]);
            BigInteger bigInteger = BigInteger.Divide(n, m);
            BigInteger bigInteger2 = BigInteger.Remainder(n, m);
            Console.WriteLine(bigInteger);
            Console.WriteLine(bigInteger2);
        }


    }


}
