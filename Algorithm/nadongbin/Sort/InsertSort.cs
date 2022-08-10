using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.Sort
{
    partial class Sort
    {
        static void InsertSort()
        {
            int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };
            int n = 10, i, j, val, flag;
            Console.WriteLine("Insertion Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            // 인서트 정렬 시작
            // 제일처음값을 기준으로 앞뒤로 삽입 정렬을 한다
            // 두번째 루프에서는  에서부터 읽어와 정렬한다
            
            //앞에서부터 하나씩
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                //기준점왼쪽으로 다시 정렬
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
