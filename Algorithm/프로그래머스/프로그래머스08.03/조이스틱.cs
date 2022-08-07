using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.프로그래머스.프로그래머스08._03
{
    internal class 조이스틱
    {
        public class SolutionExample
        {
            //조이스틱으로 알파벳 이름을 완성하세요. 맨 처음엔 A로만 이루어져 있습니다.
            /// <summary>
            /// ▲ - 다음 알파벳
            /// ▼ - 이전 알파벳(A에서 아래쪽으로 이동하면 Z로)
            /// ◀ - 커서를 왼쪽으로 이동(첫 번째 위치에서 왼쪽으로 이동하면 마지막 문자에 커서)
            /// ▶ - 커서를 오른쪽으로 이동(마지막 위치에서 오른쪽으로 이동하면 첫 번째 문자에 커서)
            /// - 첫 번째 위치에서 조이스틱을 위로 9번 조작하여 J를 완성합니다.
            /// - 조이스틱을 왼쪽으로 1번 조작하여 커서를 마지막 문자 위치로 이동시킵니다.
            /// - 마지막 위치에서 조이스틱을 아래로 1번 조작하여 Z를 완성합니다.
            /// 따라서 11번 이동시켜 "JAZ"를 만들 수 있고, 이때가 최소 이동입니다.
            /// </summary>
            public static void Main()
            {
                //Implement_4();

                string name = "JAN";
                //int answer = solution(name);
                int answer = Correctsolution(name);
                Console.WriteLine(answer);

            }
            public static int Solution(string name)
            {
                int answer = 0;
                char A = 'A';
                int hcount = name.Length - 1;
                char[] chars = name.ToCharArray();
                if (chars.Last() != 'A')
                    hcount = chars.Length - 1;

                foreach (var item in chars)
                {
                    if (item != A)
                    {
                        int count = item - A;
                        if (count < ('Z' - 'A') / 2 + 1)
                            answer += count;
                        else
                        {
                            answer += 'Z' - (item);
                        }
                    }


                }



                return answer;
            }
            public int othersolution(string name)
            {
                int answer = 0;
                foreach (var i in name)
                {
                    answer += i - 'A' >= 'Z' + 1 - i ? 'Z' + 1 - i : i - 'A';
                }
                int s = 0, e = 0, max = 0, cnt = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] == 'A')
                    {
                        cnt++;
                    }
                    else if (cnt > max)
                    {
                        max = cnt;
                        e = j;
                        s = j - max - 1;
                        cnt = 0;
                    }
                }
                if (cnt > max)
                {
                    max = cnt;
                    e = name.Length;
                    s = e - max - 1;
                }

                if (e == name.Length)
                    return answer + s;
                else
                {
                    answer += name.Length;
                    int move = -1 > s * 2 - e ? s * 2 - e : -1;
                    return answer + move;
                }

            }
            public static int othersolution2(string name)
            {
                int answer = 0;
                foreach (var i in name)
                {
                    answer += i - 'A' >= 'Z' + 1 - i ? 'Z' + 1 - i : i - 'A';
                }
                // 좌,우의 최소는 문자열 시작부터 끝가지 가는경우이다.
                int min = name.Length - 1;

                // A가 연속되는 경우에는 뒤로돌아갔을때 최솟값을 구해주어서 비교해준다.
                for (int i = 0; i < name.Length; i++)
                {
                    int index = i;

                    if (name[index] == 'A')
                    {
                        while (index < name.Length && name[index] == 'A')
                        {
                            index++;
                        }

                        // 종료시점의 index는 연속된 A가 끝나는지점이다.

                        // ((i-1)*2)은  A가 가기전까지 갔다가, 다시 Back하는 수를 세준것이다.
                        // 연속된 A가 끝나는 index까지 뒤에서 세야함으로 ( 전체길이 - index )를 해준다.
                        int moveCnt = ((i - 1) * 2) + name.Length - index;
                        min = Math.Min(min, moveCnt);
                    }

                }
                return answer + min;
            }
            public static int Correctsolution(string name)
            {
                int answer = 0;
                int n = name.Length;
                int leftOrRight = name.Length - 1;
                for (int i = 0; i < n; i++)
                {
                    int next = i + 1;
                    char target = name[i];
                    if (target <= 'N') answer += target - 'A'; //첫 알파벳이 A~N
                    else answer += 'Z' - target + 1; //첫 알파벳이  O~Z

                    // 이부분이 이해가 가지 않네 ,  n -next는 오른쪽에서 가니까인건가
                    while (next < n && name[next] == 'A') next++;
                    leftOrRight = Math.Min(leftOrRight, i + (n - next) + Math.Min(i, n - next));
                }
                answer += leftOrRight;
                return answer;

            }
        }
    }
}
