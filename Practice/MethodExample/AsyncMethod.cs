using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MethodExample
{
    public class AsyncMethodExample
    {
        public static Task AsyncMethod() => DoSomethingAsync();

        public static async Task DoSomethingAsync()
        {
            Console.WriteLine("DoSomething 시작");
            Task<int> delayTask = DelayAsync();
            int result = await delayTask;

            // The previous two statements may be combined into
            // the following statement.
            //int result = await DelayAsync();

            Console.WriteLine($"Result: {result}");
        }

        static async Task<int> DelayAsync()
        {
            await Task.Delay(100);
            return 5;
        }
    }
    // Example output:
    //   Result: 5
}
