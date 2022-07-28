using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Fundamentals
{
    
    public class AbstractExample
    {
        abstract class Shape
        {
            public abstract int GetArea();
        }
        class Square : Shape
        {
            private int _side;

            public Square(int n) => _side = n;

            // 선언하지 않으면 에러가 나온다.
            public override int GetArea() => _side * _side;

            public static void Abstaract()
            {
                var sq = new Square(12);
                Console.WriteLine($"Area of the square = {sq.GetArea()}");
            }
            
        }

    }
}
