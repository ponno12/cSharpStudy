﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int [] answers = new[] { 1, 2, 3, 4, 5 };

            int a = One(answers);
            int b = Two(answers);
            int c = Three(answers);
            int[] answer = new int[] { a,b,c };
            Array.Sort(answer);
            Console.WriteLine($" {a},{b},{c}");
            Console.WriteLine(answer);
        }   

        static int One(int[] answers)
        {
            int _correct = 0;
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == i % 5 + 1)
                {
                    _correct++;
                }
            }
            return _correct;
        }
        static int Two(int[] answers)
        {
            int _correct = 0;

            int[] twoAnswers = { 2, 1, 2, 3, 2, 4, 2, 5, 2, 1, 2, 3, 2, 4, 2, 5 };
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == twoAnswers[i % twoAnswers.Length])
                {
                    _correct++;
                }
            }
            return _correct;
        }
        static int Three(int[] answers)
        {
            int[] ThreeAnswers = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5, 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
            int _correct = 0;

            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == ThreeAnswers[i % ThreeAnswers.Length])
                {
                    _correct++;
                }
            }
            return _correct;
        }
    }
}
