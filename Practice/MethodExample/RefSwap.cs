namespace Practice.MethodExample
{
    public class RefSwapExample
    {
        public static void RefSwap()
        {
            int i = 2, j = 3;
            Console.WriteLine("i = {0}  j = {1}", i, j);

            Swap(ref i, ref j);

            Console.WriteLine("i = {0}  j = {1}", i, j);

            SwapValue(i, j);

            Console.WriteLine("i = {0}  j = {1}", i, j);
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void SwapValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
    // The example displays the following output:
    //      i = 2  j = 3
    //      i = 3  j = 2
}
