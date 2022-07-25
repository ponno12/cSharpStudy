public class LamdaExample
{

    class Product
    {
        public int Price;
        public string Color;
        public string Name;
    }


    public static void Lamda()
    {
        var value = new { Amount = 108, Message = "Hello" };


        Console.WriteLine(value.Amount + value.Message);

        var products = new[] { new { Price = 100, Color = "whitle", Name = "no.1" }, new { Price = 200, Color = "black", Name = "no.2" } };

        var productQuery =
        from prod in products
        select new { prod.Color, prod.Price };

        foreach (var v in productQuery)
        {
            Console.WriteLine("Color={0}, Price={1}", v.Color, v.Price);
        }

        var apple = new { Item = "apples", Price = 1.35 };
        var onSale = apple with { Price = 0.79 };
        Console.WriteLine(apple);
        Console.WriteLine(onSale);
    }

}
