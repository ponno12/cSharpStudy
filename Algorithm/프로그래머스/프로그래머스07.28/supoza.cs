using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    #region MyAnswer
    /*
    public class Solution
    {
        public static void Main(string[] args)
        {
            //make 1
            int[] one = { 1, 2, 3, 4, 5 };
            int[] two = { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] three = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            int[] answers = new int[] { 1, 2, 3, 4, 5 };

            int answer1 = Correct(answers, one);
            int answer2 = Correct(answers, two);
            int answer3 = Correct(answers, three);
            List<int> answer = new List<int>();

            if (answer1 == Math.Max(answer1, Math.Max(answer2,answer3)))
            {
                
                answer.Add(1);
                if (Math.Max(answer2, answer3) == answer2)
                {
                    answer.Add(2);
                    answer.Add(3);
                }
                else
                {
                    answer.Add(3);
                    answer.Add(2);
                }
            }
            else if (answer2 > answer1 && answer2 >= answer3)
            {
                answer.Add(2);
                if (Math.Max(answer1, answer3) == answer1)
                {
                    answer.Add(1);
                    answer.Add(3);
                }
                else
                {
                    answer.Add(3);
                    answer.Add(1);
                }
            }
            else
            {
                answer.Add(3);
                if (Math.Max(answer1, answer2) == answer1)
                {
                    answer.Add(1);
                    answer.Add(2);
                }
                else
                {
                    answer.Add(2);
                    answer.Add(1);
                }
            }
            answer.Sort();

            foreach (var item in answer.ToArray())
            {
                Console.WriteLine(item);
            }
        }
        public static int Correct(int[] a, int[] b)
        {
            int right = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == b[i % b.Length]) { right++; }
            }
            return right;
        }*/
    #endregion
    using System;
using System.Collections.Generic;
using System.Linq;
    public class supoza
    {
        public int[] solution(int[] answers)
        {
            int[] nRules1 = new int[] { 1, 2, 3, 4, 5 };
            int[] nRules2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] nRules3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
            int[] nScores = new int[3];
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == nRules1[i % nRules1.Length]) ++nScores[0];
                if (answers[i] == nRules2[i % nRules2.Length]) ++nScores[1];
                if (answers[i] == nRules3[i % nRules3.Length]) ++nScores[2];
            }
            List<int> lstAnswer = new List<int>();
            if (nScores[0] == nScores.Max()) lstAnswer.Add(1);
            if (nScores[1] == nScores.Max()) lstAnswer.Add(2);
            if (nScores[2] == nScores.Max()) lstAnswer.Add(3);
            return lstAnswer.ToArray();
        }
    }

}

