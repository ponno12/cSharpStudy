using System;
using System.Numerics;

namespace boj
{
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] spt = input.Split(' ');
        BigInteger n = BigInteger.Parse(spt[0]);
        BigInteger m = BigInteger.Parse(spt[1]);
        BigInteger bigInteger =  BigInteger.Divide(n,m);
        BigInteger bigInteger2 = BigInteger.Remainder(n,m);
        Console.WriteLine(bigInteger);
        Console.WriteLine(bigInteger2);
        
    }
}

}

