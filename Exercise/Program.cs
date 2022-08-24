using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    /// <summary>
    /// 배열 array의 i번째 숫자부터 j번째 숫자까지 자르고 정렬했을 때, k번째에 있는 수를 구하려 합니다.
    /// </summary>
    public class Solution
    {

        public static void Main()
        {
            
            DijikstraGraph dijikstraGraph = new DijikstraGraph();
            dijikstraGraph.Dijikstra(0);
        }
        public static int DDuck(int[] array, int count, int length)
        {
            // array를 정렬하기 위해 리스트 형태로
            List<int> ints = array.ToList();
            int total; // 잘린 떡의 길이를 구하기 위한 토탈값
            ints.Sort(); // 떡 
            // 떡을 자를 칼의 범위 지정
            int arraymin = 0;
            int arraymax = ints.Last();
            int mid;
            int result = 0;
            ints.Sort();
            while (arraymin<=arraymax)
            { 
                total = 0;
                mid = (arraymin + arraymax) / 2;
                foreach (var item in array)
                {   
                    if(item > mid)
                        total += item - mid;
                }
                if(total < length)
                {
                    arraymax = mid-1;
                }
                else
                {
                    result = mid;
                    arraymin = mid+1;
                }

            }
            return result;
        }

        public static int MakeOne(int num)
        {
            int maxCount = 0;

            while(num > 1)
            {
                if (num % 5 == 0)
                {
                    num = num / 5;
                    maxCount++;
                }
                else if (num % 3 == 0)
                {
                    num = num / 3;
                    maxCount++;
                }
                else if (num % 2 == 0)
                {
                    num = num / 2;
                    maxCount++;
                }
                else
                {
                    num--;
                    maxCount++;
                }
            }
            
            return maxCount;
        }
       
        public static int MakeOneDynamic(int x)
        {
            int[] d = new int[30000];
            // 다이나믹 프로그래밍(Dynamic Programming) 진행(보텀업)
            for (int i = 2; i <= x; i++)
            {
                // 현재의 수에서 1을 빼는 경우
                d[i] = d[i - 1] + 1;
                // 현재의 수가 2로 나누어 떨어지는 경우
                if (i % 2 == 0)
                    d[i] = Math.Min(d[i], d[i / 2] + 1);
                // 현재의 수가 3으로 나누어 떨어지는 경우
                if (i % 3 == 0)
                    d[i] = Math.Min(d[i], d[i / 3] + 1);
                // 현재의 수가 5로 나누어 떨어지는 경우
                if (i % 5 == 0)
                    d[i] = Math.Min(d[i], d[i / 5] + 1);
            }
            return d[x];
        }        

        public static int AntWarrior(int[] x)
        {
            int[] d = new int[100];

            d[0] = x[0];
            d[1] = Math.Max(x[0], x[1]);
            for (int i = 2; i < x.Length; i++)
            {
                d[i] = Math.Max(d[i - 1], d[i - 2] + x[i]);
            }
            return d[x.Length -1];
        }
        
        public static int MakeBottom(int n)
        {
            int[] d = new int[1000];
            d[1] = 1;
            d[2] = 3;
            for (int i = 3; i <= n; i++)
            {
                d[i] = d[i - 1] + 2 * d[i - 2];
            }
            
            return d[n];
        }
        
        public static int Money(int[] arr , int m)
        {
            // 앞서 계산된 결과를 저장하기 위한 DP 테이블 초기화 
            int[] d = new int[m + 1];
            Array.Fill(d, 10001);

            // 다이나믹 프로그래밍(Dynamic Programming) 진행(보텀업)
            d[0] = 0;
            for (int i = 0; i <arr.Length; i++)
            {
                for (int j = arr[i]; j <= m; j++)
                {
                    // (i - k)원을 만드는 방법이 존재하는 경우
                    if (d[j - arr[i]] != 10001)
                    {
                        d[j] = Math.Min(d[j], d[j - arr[i]] + 1);
                    }
                }
                
            }
            if (d[m] == 10001)
                return -1;
            else
                return d[m];
        }
    }
    public class DijikstraGraph
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

            distance[start] = 0;
            parent[start] = start;

            while (true)
            {
                // 제일 좋은 후보를 찾는다. 

                // 가장 유력한 정점의 거리와 번호를 저장한다.
                int closet = Int32.MaxValue;
                int now = -1;

                // 방문하지 않은 정점중에 제일 짧은 정점을 반환
                // 우선순위 큐를 쓸
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
                    }
                }
                
            }
            foreach (var d in distance)
            {
                Console.WriteLine(d);
            }
        }
    }
    public class PriorityDijikstra
    {
        PriorityQueue<int, int> priorQueue = new PriorityQueue<int, int>();
        const int INF = 10000000;
        public void Dijkstra(int start, int[] d, List<KeyValuePair<int, int>>[] road)
        {
            int cur,     // 현재 노드
                dis,     // 현재 노드까지의 거리
                next,    // 다음 노드
                nextdis; // 다음 노드까지의 거리

            List<KeyValuePair<int, int>> lis;
            d[start] = 0;
            priorQueue.Enqueue(start, 0);

            while (0 != priorQueue.Count)
            {

                priorQueue.TryDequeue(out cur, out dis);

                if (dis > d[cur])
                {
                    continue;
                }
                lis = road[cur];
                if (lis == null)
                {
                    continue;
                }
                for (int i = 0; i < lis.Count; ++i)
                {
                    next = lis[i].Key;
                    nextdis = dis + lis[i].Value;
                    if (nextdis < d[next])
                    {
                        d[next] = nextdis;
                        priorQueue.Enqueue(next, nextdis);

                    }
                }
            }
        }
    }
}
