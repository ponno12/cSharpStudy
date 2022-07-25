namespace Practice.MethodExample
{
    public class SampleRefType
    {
        public int value;
    }

    public class ByRefTypeExample
    {
        public static void RefTypeMethod()
        {
            var rt = new SampleRefType();
            rt.value = 44;
            ModifyObject(ref rt);
            Console.WriteLine(rt.value);
        }

        static void ModifyObject(ref SampleRefType obj)
        {
            obj.value = 33;
        }
    }
}
