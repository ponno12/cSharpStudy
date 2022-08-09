using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.DFSNBFS
{
    public class Solution
    {
        static int[,] n = {
                {0,0,1,1,0 },
                {0,0,0,1,1 },
                {1,1,1,1,1 },
                {0,0,0,0,0 }
            };

        static int count = 0;
        static int[,] visited = n;

        public static void Main()
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (DFS(i, j) == true)
                        count += 1;
                }
            }
            Console.WriteLine(count);
        }
        static bool DFS(int x, int y)  // 순회 시작 위치가 인수로 들어 옴
        {
            if (x <= -1 || x > 3 || y <= -1 || y > 4)
                return false;

            if (visited[x, y] == 0)
            {
                Console.WriteLine($" x : {x} y : {y}");
                visited[x, y] = 1;
                DFS(x - 1, y);
                DFS(x, y - 1);
                DFS(x + 1, y);
                DFS(x, y + 1);
                return true;
            }
            return false;
        }
    }
}
