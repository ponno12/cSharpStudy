using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.Implement
{
    partial class Implement
    {
        public enum Movement
        {
            L = 0,
            R = 1,
            U = 2,
            D = 3
        }
        public static void Implement_1()
        {
            int a = Convert.ToInt32(Console.ReadLine());

            int[,] map = new int[a, a];
            int x, y;
            x = y = 1;
            int[] dx = new int[] { 0, 0, -1, 1 };
            int[] dy = new int[] { -1, 1, 0, 0 };

            char[] plane = new char[] { 'R', 'R', 'R', 'U', 'D', 'D' };
            foreach (char item in plane)
            {
                int nx, ny;
                nx = ny = 0;
                Console.WriteLine($"{x} and {y}");
                switch (item)
                {
                    case 'L':
                        nx = x + dx[(int)Movement.L];
                        ny = y + dy[(int)Movement.L];
                        break;
                    case 'R':
                        nx = x + dx[(int)Movement.R];
                        ny = y + dy[(int)Movement.R];
                        break;
                    case 'U':
                        nx = x + dx[(int)Movement.U];
                        ny = y + dy[(int)Movement.U];
                        break;
                    case 'D':
                        nx = x + dx[(int)Movement.D];
                        ny = y + dy[(int)Movement.D];
                        break;
                    default:
                        break;
                }
                if (nx < 1 || ny < 1 || nx > a || ny > a)
                    continue;
                x = nx;
                y = ny;
            }
            Console.WriteLine($"{x} and {y}");


        }
    }
}
