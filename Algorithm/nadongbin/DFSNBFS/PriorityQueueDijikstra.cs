using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.DFSNBFS
{
    class DijikstraGraph2
    {
        // -1 은 연결 안된 상태를 표시
        int[,] adj = new int[6, 6]
        {
            { -1, 15, -1, 35, -1, -1 },
            { 15, -1, 5, 10, -1, -1 },
            { -1, 5, -1, -1, -1, -1 },
            { 35, 10, -1, -1, 5, -1 },
            { -1, -1, -1, 5, -1, 5 },
            { -1, -1, -1, -1, 5, -1 },
        };

        public void Dijikstra(int start)
        {
            bool[] visited = new bool[6];
            int[] distance = new int[6];
            Array.Fill(distance, Int32.MaxValue);
            int[] parent = new int[6];
            PriorityQueue<int,int> priorityQueue = new PriorityQueue<int,int>();
            distance[start] = 0;


            while (true)
            {
                // 제일 좋은 후보를 찾는다. 

                // 가장 유력한 정점의 거리와 번호를 저장한다.
                int closet = Int32.MaxValue;
                int now = -1;

                // 방문하지 않은 정점중에 제일 짧은 정점을 반환
                /*for (int i = 0; i < 6; i++)
                {
                    // 이미 방문한 정점은 스킵
                    if (visited[i])
                        continue;
                    // 아직 발견(예약)된 적이 없거나, 기존 후보보다 멀리 있으면 스킵
                    if (distance[i] == Int32.MaxValue || distance[i] >= closet)
                        continue;

                    // 지금 시점까지 발견한 가장 좋은 후보
                    closet = distance[i];
                    now = i;
                }*/

                if (now == -1)  // 다음 후보가 하나도 없으므로 종료
                    break;

                // 제일 좋은 후보를 찾았으니까 방문한다.
                visited[now] = true;

                // 방문한 정점과 연결되어 있는 정점들을 조사해서
                // 상황에 따라 발견한 최단 거리를 갱신한다.
                for (int next = 0; next < 6; next++)
                {
                    // 연결되지 않은 정점은 스킵
                    if (adj[now, next] == -1)
                        continue;
                    // 이미 방문한 정점은 스킵
                    if (visited[next])
                        continue;

                    // 새로 조사된 정점의 최단 거리를 계산한다.
                    int nextDist = distance[now] + adj[now, next];
                    // 만약에 기존에 발견한 최단 거리가 새로 조사된 최단거리보다 크면 정보를 갱신
                    if (nextDist < distance[next])
                    {
                        distance[next] = nextDist;
                        parent[next] = now;
                    }
                }
            }
        }
    }
}
