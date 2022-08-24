using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.DFSNBFS
{
    internal class 다익스트라우선순위
    {
    }
}

 
namespace PrjGraph
{
    class GraphAlgorithm
    {
        class Graph
        {
            private int n;          //노드들의 수
            private int[,] maps;    //노드들간의 가중치 저장할 변수

            public Graph(int n)
            {
                this.n = n;
                maps = new int[n + 1, n + 1];
            }
            public void input(int i, int j, int w)
            {
                maps[i, j] = w;
                //maps[j,i] = w;    // 양방향으로 하려면 주석 제거
            }

            public void dijkstra(int v)
            {
                int[] distance = new int[n + 1];   // 최단 거리를 저장할 변수
                bool[] check = new bool[n + 1];     //해당 노드를 방문했는지 체크할 변수

                //distance값 초기화.
                for (int i = 1; i < n + 1; i++)
                {
                    distance[i] = int.MaxValue;
                }

                //시작노드값 초기화.
                distance[v] = 0;
                check[v] = true;

                //연결노드 distance갱신
                for (int i = 1; i < n + 1; i++)
                {
                    if (!check[i] && maps[v, i] != 0)
                    {
                        distance[i] = maps[v, i];
                    }
                }


                for (int a = 0; a < n - 1; a++)
                {
                    //원래는 모든 노드가 true될때까지 인데
                    //노드가 n개 있을 때 다익스트라를 위해서 반복수는 n-1번이면 된다.
                    //원하지 않으면 각각의 노드가 모두 true인지 확인하는 식으로 구현해도 된다.
                    int min = int.MaxValue;
                    int min_index = -1;

                    //최소값 찾기
                    for (int i = 1; i < n + 1; i++)
                    {
                        if (!check[i] && distance[i] != int.MaxValue)
                        {
                            if (distance[i] < min)
                            {
                                min = distance[i];
                                min_index = i;
                            }
                        }
                    }

                    if (min_index != -1)
                    {
                        check[min_index] = true;
                        for (int i = 1; i < n + 1; i++)
                        {
                            if (!check[i] && maps[min_index, i] != 0)
                            {
                                if (distance[i] > distance[min_index] + maps[min_index, i])
                                {
                                    distance[i] = distance[min_index] + maps[min_index, i];
                                }
                            }
                        }
                    }
                }

                //결과값 출력
                for (int i = 1; i < n + 1; i++)
                {
                    if (distance[i] == int.MaxValue)
                        Console.WriteLine("INF");
                    else
                        Console.WriteLine(distance[i]);
                }
            }
        }

        static int V, K, E;

        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            V = int.Parse(words[0]);
            E = int.Parse(words[1]);
            K = int.Parse(Console.ReadLine());
            Graph g = new Graph(V);

            for (int i = 0; i < E; i++)
            {
                words = Console.ReadLine().Split(' ');
                int num1 = int.Parse(words[0]);
                int num2 = int.Parse(words[1]);
                int weight = int.Parse(words[2]);
                g.input(num1, num2, weight);
            }

            g.dijkstra(K);
        }
    }
}