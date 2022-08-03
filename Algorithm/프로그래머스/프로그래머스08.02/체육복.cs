using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.프로그래머스.프로그래머스08._02
{
    //
    // 점심시간에 도둑이 들어, 일부 학생이 체육복을 도난당했습니다.
    // 다행히 여벌 체육복이 있는 학생이 이들에게 체육복을 빌려주려 합니다.
    // 학생들의 번호는 체격 순으로 매겨져 있어, 바로 앞번호의 학생이나 바로
    // 뒷번호의 학생에게만 체육복을 빌려줄 수 있습니다.
    // 예를 들어, 4번 학생은 3번 학생이나 5번 학생에게만 체육복을 빌려줄 수 있습니다.
    // 체육복이 없으면 수업을 들을 수 없기 때문에 체육복을 적절히 빌려 최대한 많은 학생이
    // 체육수업을 들어야 합니다.
    // 전체 학생의 수 n, 체육복을 도난당한 학생들의 번호가 담긴 배열 lost,
    // 여벌의 체육복을 가져온 학생들의 번호가 담긴 배열 reserve가 매개변수로 주어질 때,
    // 체육수업을 들을 수 있는 학생의 최댓값을 return 하도록 solution 함수를 작성해주세요.
    //
    partial class Solution
    {
        public static int solution(int n, int[] lost, int[] reserve)
        {
            int answer = 0;

            answer = n - lost.Length;
            List<int> reservelist = new List<int>(reserve);
            List<int> lostList = new List<int>(lost);
            reservelist.Sort();
            lostList.Sort();

            foreach (var item in lostList)
            {
                if (reservelist.Contains(item))
                {
                    answer++;
                    reservelist.Remove(item);
                }
            }

            foreach (var item in lostList)
            {

                if (reservelist.Contains(item + 1))
                {
                    answer++;
                    reservelist.Remove(item + 1);
                }
                else if (reservelist.Contains(item - 1) && item != 1)
                {
                    answer++;
                    reservelist.Remove(item - 1);
                }
            }
            Console.WriteLine(answer);
            return answer;
        }
        // 다른 사람 풀이
        public int solution(int n, int[] lost, int[] reserve)
        {
            Array.Sort(lost);
            Array.Sort(reserve);

            //체육복 잃어버린 학생 반복
            foreach (int l in lost)
            {
                //여벌 체육복 학생 반복
                foreach (int r in reserve)
                {
                    //체육복 잃어버린 학생 번호랑 여벌 체육복 학생 번호랑 같으면
                    if (l == r)
                    {
                        //자기 자신이 입으므로 해당 배열에서 모두 제거
                        lost = lost.Where(x => x != l).ToArray();
                        reserve = reserve.Where(x => x != r).ToArray();
                        break;
                    }
                }
            }

            int count = 0;
            //체육복 잃어버린 학생 반복
            foreach (int l in lost)
            {
                //여벌 체육복 학생 반복
                for (int i = 0; i < reserve.Length; i++)
                {
                    //잃어버린 체육복 학생 번호 -1 or +1 이 여벌 체육복 학생 번호랑 같고
                    //여벌 체육복 학생 번호가 0이 아니면
                    if (l - 1 == reserve[i] && reserve[i] != 0
                         || l + 1 == reserve[i] && reserve[i] != 0)
                    {
                        //여벌 체육복 학생 번호 0으로, 빌려준 카운트 더하기
                        reserve[i] = 0;
                        count++;
                        break;
                    }
                }
            }
            //총 들을 수 있는 학생수는 전체 학생 수 - 잃어버린 학생 수 + 빌려준 카운트
            return n - lost.Length + count;
        }

    }
}
