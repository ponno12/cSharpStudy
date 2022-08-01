using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.프로그래머스_07._30
{
    using System;
    using System.Linq;

    public class Lotoo
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int winCount = lottos.Intersect(win_nums).Count();
            //int winCount2 = lottos.Contains(win_nums).Count();
            int loseCount = lottos.Where((number) => number != 0).Count() - winCount;

            int[] answer = new int[] { WinCountToRank(6 - loseCount), WinCountToRank(winCount) };
            return answer;
        }

        public int WinCountToRank(int count)
        {
            if (count <= 1)
            {
                return 6;
            }

            return 7 - count;
        }
    }
    #region Myanswer
    /*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
    {
        public class Solution
        {
            public static void Main(int[] lottos, int[] win_nums)
            {
                List<int> answer = new List<int>();
                int minCorrect = 0;
                int maxCorrect = 0;

                for (int i = 0; i < lottos.Length; i++)
                {
                    if (lottos[i] == 0)
                        maxCorrect++;
                    for (int j = 0; j < win_nums.Length; j++)
                    {
                        if (lottos[i] == win_nums[j])
                        {
                            minCorrect++;
                        }
                    }
                }
                maxCorrect += minCorrect;

                switch (maxCorrect)
                {
                    case 0:
                        answer.Add(6);
                        break;
                    case 1:
                        answer.Add(6);
                        break;
                    case 2:
                        answer.Add(5);
                        break;
                    case 3:
                        answer.Add(4);
                        break;
                    case 4:
                        answer.Add(3);
                        break;
                    case 5:
                        answer.Add(2);
                        break;
                    case 6:
                        answer.Add(1);
                        break;
                }
                switch (minCorrect)
                {
                    case 0:
                        answer.Add(6);
                        break;
                    case 1:
                        answer.Add(6);
                        break;
                    case 2:
                        answer.Add(5);
                        break;
                    case 3:
                        answer.Add(4);
                        break;
                    case 4:
                        answer.Add(3);
                        break;
                    case 5:
                        answer.Add(2);
                        break;
                    case 6:
                        answer.Add(1);
                        break;
                }

                answer.ToArray();
            }
        }

    }*/


    #endregion


}
