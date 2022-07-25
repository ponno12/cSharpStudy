namespace Practice.Iterators
{
    public class IteratorsExample
    {
        public static void Iteraotr()
        {
            ForeachExamples.ExampleOne();

            foreach (var item in IteratorMethods.GetSingleDigitNumbers())
                Console.WriteLine(item);

            foreach (var item in IteratorMethods.GetSingleDigitNumbersV2())
                Console.WriteLine(item);

            foreach (var item in IteratorMethods.GetSingleDigitNumbersAndNumbersOver100())
                Console.WriteLine(item);
        }
    }
}
