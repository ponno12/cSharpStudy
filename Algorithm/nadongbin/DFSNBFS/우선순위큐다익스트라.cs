using System.Collections;
using System.Collections.Generic;

namespace Algorithm.nadongbin.DFSNBFS
{
    class 다익스트라
    {
        Periority_Queue pq = new Periority_Queue();
        PriorityQueue<int,int> priorQueue= new PriorityQueue<int,int>();
        const int INF = 10000000;

        public class Periority_Queue
        {
            private List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();

            int index;
            KeyValuePair<int, int> temp;

            public void push(KeyValuePair<int, int> value)
            {
                if (list.Count == 0)
                {
                    list.Add(value);
                    return;
                }
                index = 0;
                for (int i = list.Count - 1; i >= 0; --i)
                {
                    temp = list[i];
                    if (temp.Key < value.Value)
                    {
                        index = i + 1;
                        break;
                    }
                }
                list.Insert(index, value);
            }
            public KeyValuePair<int, int> Pop
            {
                get
                {
                    temp = list[0];
                    list.RemoveAt(0);
                    return temp;
                }
            }
            public KeyValuePair<int, int> Top { get { return list[0]; } }
            public int Count { get { return list.Count; } }
        }

        public void Dijkstra(int start, int[] d, List<KeyValuePair<int, int>>[] road)
        {
            int cur,     // 현재 노드
                dis,     // 현재 노드까지의 거리
                next,    // 다음 노드
                nextdis; // 다음 노드까지의 거리

            List<KeyValuePair<int, int>> lis;
            d[start] = 0;
            pq.push(new KeyValuePair<int, int>(start, 0));
            priorQueue.Enqueue(start,0);
            
            while (0 != priorQueue.Count)
            {

                priorQueue.TryDequeue(out cur,out dis);
                
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

        public int solution(int n, int[,] road, int k)
        {
            var length = n + 1;
            int index = 0;
            List<KeyValuePair<int, int>>[] roadList = new List<KeyValuePair<int, int>>[length];
            int[] distance = new int[length];

            for (index = 1; index < length; ++index)
            {
                distance[index] = INF;
                roadList[index] = new List<KeyValuePair<int, int>>();
            }

            for (index = 0; index < road.Length / 3; ++index)
            {
                roadList[road[index, 0]].Add(new KeyValuePair<int, int>(road[index, 1], road[index, 2]));
                roadList[road[index, 1]].Add(new KeyValuePair<int, int>(road[index, 0], road[index, 2]));
            }

            Dijkstra(1, distance, roadList);

            int count = 0;
            for (index = 1; index < length; ++index)
            {
                if (distance[index] <= k)
                {
                    ++count;
                }
            }
            return count;
        }
    }
}
