using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.DFSNBFS
{
    public class DFS
    {
        static void DFSExample(string[] args)
        {
            GraphArray graphArray = new GraphArray();
            graphArray.DFS(3);  // 3 0 1 2 4 5
            GraphList  graphList = new GraphList();
            graphList.DFS2(0);
        }
    }
    class GraphArray
    {
        int[,] adj = new int[6, 6]
        {
            { 0, 1, 0, 1, 0, 0 },
            { 1, 0, 1, 1, 0, 0 },
            { 0, 1, 0, 0, 0, 0 },
            { 1, 1, 0, 0, 1, 0 },
            { 0, 0, 0, 1, 0, 1 },
            { 0, 0, 0, 0, 1, 0 },
        };

        bool[] visited = new bool[6]; // 방문 체크를 위해

        public void DFS(int now)  // 순회 시작 위치가 인수로 들어 옴
        {
            // 1) now 부터 방문 하고
            Console.WriteLine(now);
            visited[now] = true;

            // 2) now 와 연결된 정점들을 하나씩 확인해서, [ 아직 미 방문 상태라면 ] 방문한다.
            for (int next = 0; next < 6; next++)
            {
                if (adj[now, next] == 0)  // 연결 되어 있지 않으면 스킵
                    continue;
                if (visited[next])      // 이미 방문 했으면 스킵
                    continue;
                DFS(next);   // 재귀 (깊이 들어 감)
            }
        }
    }

    class GraphList
    {
        List<int>[] adj2 = new List<int>[]
        {
            new List<int>() { 1, 3 },
            new List<int>() { 0, 2, 3 },
            new List<int>() { 1 },
            new List<int>() { 0, 1, 4 },
            new List<int>() { 3, 5 },
            new List<int>() { 4 },
        };

        bool[] visited = new bool[6];

        public void DFS2(int now)
        {
            // 1) now 부터 방문 하고
            Console.WriteLine(now);
            visited[now] = true;

            // 2) now 와 연결된 정점들을 하나씩 확인해서, [ 아직 미 방문 상태라면 ] 방문한다.
            foreach (int next in adj2[now])
            {
                if (visited[next])      // 이미 방문 했으면 스킵
                    continue;
                DFS2(next);
            }
        }
    }
}
