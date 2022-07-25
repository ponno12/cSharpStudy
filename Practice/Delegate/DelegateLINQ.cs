using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Delegate
{
    public class DelegateLINQExample
    {

        public static void DelegateLINQ()
        {
            int[] numbers = new[] { 1, 2, 3, 4, 5,145,1515 };
            var smallNumbers = numbers.Where(n => n < 10);
            foreach (var number in smallNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
