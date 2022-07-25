namespace Practice.MethodExample
{

    public class Options
    {
        public void ExampleMethod(int required, int optionalInt = default,
                                  string? description = default)
        {
            var msg = $"{description ?? "N/A"}: {required} + {optionalInt} = {required + optionalInt}";
            Console.WriteLine(msg);
        }
    }
    public class OptionMethodExample
    {
        public static void OptionMethod()
        {
            var opt = new Options();
            opt.ExampleMethod(10);
            opt.ExampleMethod(10, 2);
            opt.ExampleMethod(12, description: "Addition with zero:");
        }
    }
}
