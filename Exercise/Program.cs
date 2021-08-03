using System;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();



            Queue<int> queue = new Queue<int>();

            queue.Enqueue(101);
            queue.Enqueue(102);
            queue.Enqueue(103);
            queue.Enqueue(104);
            queue.Enqueue(105);
            queue.Enqueue(106);
            queue.Enqueue(107);

            int data3 = queue.Dequeue();
            int data4 = queue.Peek();
        }

    }
}
