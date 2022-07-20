using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Fundamentals
{
    using System;

    public class Vegetable
    {
        public Vegetable(string name) => Name = name;

        public string Name { get; }

        public override string ToString() => Name;
    }

    public class Program
    {
        public enum Unit { item, kilogram, gram, dozen };
        //문자열 보간을 뜻함
        public static void StringInterploation()
        {
            var item = new Vegetable("eggplant");
            var date = DateTime.Now;
            var price = 1.99m;
            var unit = Unit.item;
            Console.WriteLine($"On {date}, the price of {item} was {price} per {unit}.");
        }
    }
}
