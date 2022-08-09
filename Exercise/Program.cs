using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    /// <summary>
    /// ROR 게임은 두 팀으로 나누어서 진행하며, 상대 팀 진영을 먼저 파괴하면 이기는 게임입니다.
    /// 따라서, 각 팀은 상대 팀 진영에 최대한 빨리 도착하는 것이 유리합니다.
    /// </summary>
    public class Solution
    {
        public static int[,] maps = new int[,] {
                { 1, 0, 1, 1, 1 },
                { 1, 0, 1, 0, 1 },
                { 1, 0, 1, 1, 1 },
                { 1, 1, 1, 0, 1 },
                { 0, 0, 0, 0, 1 }
            };
        static int[] dx = { 0, 0, +1, -1 };
        static int[] dy = { 1, -1, 0, 0 };
        int count = 1;
        int nx = 0;
        int ny = 0;
        public static Queue<(int, int)> queue = new Queue<(int, int)>();
        public static void Main()
        {
            

        }
        

        public int solution(int[,] maps)
        {

            int[,] arr = maps;
            nx = arr.GetLength(0);
            ny = arr.GetLength(1);
            BFS(nx, ny, arr);

            if (arr[nx - 1, ny - 1] == 1)
            {
                return -1;
            }
            else
            {
                return (arr[nx - 1, ny - 1]);
            }
        }

        public int BFS(int i, int j, int[,] arr)
        {
            
            queue.Enqueue(new int[,] { }));

            while(queue.Count > 0)
            {
                for (int i = 0; i < 4; i++)
                {

                    if (maps[nx,ny] ==0)
                    nx = nx + dx[i];
                    ny = ny + dy[i];
                }
            }

            return count;

        }

        public void bfs(int i, int j, int[,] arr)
        {
            queue.Enqueue((i, j));
            while (queue.Count != 0)
            {
                (int a, int b) = queue.Dequeue();
                for (int k = 0; k < 4; k++)
                {
                    int x = a + dx[k];
                    int y = b + dy[k];
                    if ((0 <= x && x < nx) && (0 <= y && y < ny) && (arr[x, y] == 1))
                    {
                        queue.Enqueue((x, y));
                        arr[x, y] = arr[a, b] + 1;
                    }
                }
            }
        }
    }
}
