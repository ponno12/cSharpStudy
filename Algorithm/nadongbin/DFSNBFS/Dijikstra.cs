using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.DFSNBFS
{
    class DijikstraGraph
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
            // parent의 경우 필수는 아님
            // int[] parent = new int[6];

            distance[start] = 0;
            // parent[start] = start;

            while (true)
            {
                // 제일 좋은 후보를 찾는다. 

                // 가장 유력한 정점의 거리와 번호를 저장한다.
                int closet = Int32.MaxValue;
                int now = -1;

                // 방문하지 않은 정점중에 제일 짧은 정점을 반환
                // 우선순위 큐를쓰면 이부분을 간소화 가능
                for (int i = 0; i < 6; i++)
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
                }

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
                        //parent[next] = now;
                    }
                }
            }
        }
    }
    partial class Solution
    {
        public int solution(int N, int[,] road, int K)
        {
            // 제일먼저 해야할것으로 비용그래프를 만들고, 시작점 외에는 최고값 대입
            int[] nCosts = new int[N];
            /*for (int i = 0; i < N; i++)
            {
                if (i == 0) nCosts[0] = 0;
                else nCosts[i] = int.MaxValue;
            }*/
            Array.Fill(nCosts, Int32.MaxValue);
            nCosts[0] = 0;
            Queue<int> que = new Queue<int>();
            que.Enqueue(1); // 시작위치 집어넣기
            while (que.Count() > 0)
            {
                int nCurrent = que.Dequeue();
                // 출발지가 i인 곳에 연결된 마을의 Cost를 설정
                for (int i = 0; i < road.GetLength(0); i++)
                {
                    int nStart = road[i, 0];
                    int nEnd = road[i, 1];
                    int nCost = road[i, 2];
                    if (nStart == nCurrent)
                    {
                        if (nCosts[nEnd - 1] > nCost + nCosts[nStart - 1])
                        {
                            nCosts[nEnd - 1] = nCost + nCosts[nStart - 1];
                            que.Enqueue(nEnd);
                        }
                    }
                    else if (nEnd == nCurrent)
                    {
                        if (nCosts[nStart - 1] > nCost + nCosts[nEnd - 1])
                        {
                            nCosts[nStart - 1] = nCost + nCosts[nEnd - 1];
                            que.Enqueue(nStart);
                        }
                    }
                }
            }
            return nCosts.Where(x => x <= K).Count();
        }
    }
}
