using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.Implement
{
    partial class Implement
    {

        public enum Alphabet
        {
            a, b, c, d, e, f, g, h
        }
        public static void Implement_3()
        {

            int[,] a = new int[7, 7];
            string a1 = Console.ReadLine();
            char[] a2 = a1.ToCharArray();
            //Enum을 사용하여 값 매칭
            int y = (int)Enum.Parse(typeof(Alphabet), a1);
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(y);

            int count = 0;


            int[] dx = { -2, -2, -1, 1, 2, 2, -1, 1 };
            int[] dy = { -1, 1, 2, 2, 1, -1, -2, -2 };
            for (int i = 0; i < 8; i++)
            {
                int n_x = x + dx[i];
                int n_y = y + dy[i];

                if (n_x >= 0 && n_y >= 0 && n_x <= 7 && n_y <= 7)
                    count++;
            }
            Console.WriteLine(count);


        }

    }
}
