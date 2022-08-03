using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    partial class Solution
    {
        public static void Main()
        {
            //Implement_4();

            int n = 5;
            int[] lost = new int[] { 2, 4 };
            int[] reserve = new int[] { 1, 3, 5 };
            solution(n, lost, reserve);

        }

        public enum Movement
        {
            L = 0,
            R = 1,
            U = 2,
            D = 3
        }
        public static void Implement_1()
        {
            int a = Convert.ToInt32(Console.ReadLine());

            int[,] map = new int[a, a];
            int x, y;
            x = y = 1;
            int[] dx = new int[] { 0, 0, -1, 1 };
            int[] dy = new int[] { -1, 1, 0, 0 };

            char[] plane = new char[] { 'R', 'R', 'R', 'U', 'D', 'D' };
            foreach (char item in plane)
            {
                int nx, ny;
                nx = ny = 0;
                Console.WriteLine($"{x} and {y}");
                switch (item)
                {
                    case 'L':
                        nx = x + dx[(int)Movement.L];
                        ny = y + dy[(int)Movement.L];
                        break;
                    case 'R':
                        nx = x + dx[(int)Movement.R];
                        ny = y + dy[(int)Movement.R];
                        break;
                    case 'U':
                        nx = x + dx[(int)Movement.U];
                        ny = y + dy[(int)Movement.U];
                        break;
                    case 'D':
                        nx = x + dx[(int)Movement.D];
                        ny = y + dy[(int)Movement.D];
                        break;
                    default:
                        break;
                }
                if (nx < 1 || ny < 1 || nx > a || ny > a)
                    continue;
                x = nx;
                y = ny;
            }
            Console.WriteLine($"{x} and {y}");


        }
        public static void Implement_2()
        {
            int a = Convert.ToInt32(Console.ReadLine());

            int minuteCount = 0;

            for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    for (int k = 0; k < 60; k++)
                    {
                        string temp = i.ToString() + j.ToString() + k.ToString();
                        if (temp.Contains('3'))
                        {
                            Console.WriteLine(temp);
                            minuteCount++;
                        }
                    }
                    
                }
            }
            
            Console.WriteLine(minuteCount);
        }
        public enum Alphabet
        {
            a,b,c,d,e,f,g,h
        }
        public static void Implement_3()
        {
         
            int[,] a = new int[7, 7];
            string a1 = Console.ReadLine();
            char[] a2 = a1.ToCharArray();
            //Enum을 사용하여 값 매칭
            int y = (int)Enum.Parse(typeof(Alphabet), a1);
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(y);

            int count =0;


            int[] dx = { -2, -2, -1, 1, 2, 2, -1, 1 };
            int[] dy = { -1, 1, 2, 2, 1, -1, -2, -2 };
            for (int i = 0; i < 8; i++)
            {
                int n_x = x + dx[i];
                int n_y = y + dy[i];

                if (n_x >= 0 && n_y >= 0 && n_x <= 7 && n_y <= 7)
                    count++;
            }
            Console.WriteLine(count);


        }

        public static void Implement_4()
        {
            string a = Console.ReadLine();
            char[] chars = a.ToCharArray();
            
            List<int> listInt = new List<int>();
            List<char> listchar = new List<char>();
            foreach (var item in chars)
            {
                if (Char.IsLetter(item))
                {
                    listchar.Add(item);
                }
                else if (Char.IsDigit(item))
                {
                    listInt.Add((int)Char.GetNumericValue(item));
                }
            }
            listchar.Sort();
            string answerString =new string(listchar.ToArray()) ;
            int answerInt = listInt.Sum();
            Console.WriteLine(answerString +answerInt.ToString());
            Console.WriteLine(answerInt);

        }

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
                    reservelist.Remove(item+1);
                }
                else if (reservelist.Contains(item -1) && item!=1)
                {
                    answer++;
                    reservelist.Remove(item - 1);
                }
            }
            Console.WriteLine(answer);
            return answer;
        }

    }
}
