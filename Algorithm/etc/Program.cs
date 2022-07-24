using System;
using System.Collections;
using System.Numerics;

class Program
{
    private static (int Max, int Min) Range(IEnumerable<int> numbers)
    {
        int min = int.MinValue;
        int max = int.MaxValue;
        foreach (int n in numbers)
        {
            min = (n < min) ? n : min;
            max = (n > max) ? n : max;
        }
        return (max, min);
    }

    static void Main(string[] args)
    {

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        (int a, int b) = Range(numbers);
        Console.WriteLine($"{a} & {b}");
    }
}


