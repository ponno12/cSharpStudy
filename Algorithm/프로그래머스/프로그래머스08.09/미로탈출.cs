using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.DFSNBFS
{
    /// <summary>
    /// 첫째 줄에 두 정수 N, 다음 N개의 줄에는 각각 M개의 정수( 0혹은 1)로 미로정보가 주어집니다
    /// 각각의 수들은 공백없이 붙어서 입력으로 제시도비니다. 탈출하는데 필요한 최소 이동칸의 개수
    /// </summary>

    class Solution
    {
        int n = 0;
        int m = 0;
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        Queue<(int, int)> que = new Queue<(int, int)>();

        public void bfs(int i, int j, int[,] arr)
        {
            que.Enqueue((i, j));
            while (que.Count != 0)
            {
                (int a, int b) = que.Dequeue();
                for (int k = 0; k < 4; k++)
                {
                    int x = a + dx[k];
                    int y = b + dy[k];
                    if ((0 <= x && x < n) && (0 <= y && y < m) && (arr[x, y] == 1))
                    {
                        que.Enqueue((x, y));
                        arr[x, y] = arr[a, b] + 1;
                    }
                }
            }
        }
        public int solution(int[,] arr)
        {
            n = arr.GetLength(0);
            m = arr.GetLength(1);

            bfs(0, 0, arr);

            if (arr[n - 1, m - 1] == 1)
            {
                return -1;
            }
            else
            {
                return (arr[n - 1, m - 1]);
            }

        }
    }
}
