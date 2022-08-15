﻿using System;
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
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int answer = (int)MyBinarySearch(array, 9, 0,9);
            Console.WriteLine(answer);
        }

        
            //반복문으로 하는버전
        public static object BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "Nil";
        }
        // 재귀함수로 하는버전
        public static object BinarySearchRecursive(int[] inputArray, int key, int min, int max)
        {
            if (min > max)
            {
                return "Nil";
            }
            else
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    return BinarySearchRecursive(inputArray, key, min, mid - 1);
                }
                else
                {
                    return BinarySearchRecursive(inputArray, key, mid + 1, max);
                }
            }
        }
        
        public static object MyBinarySearch(int[] array, int key, int min, int max)
        {
            if (min > max)
                return 1000;
            else
            {
                int mid = (min + max) / 2;
                if (array[mid] == key)
                {
                    return ++mid;
                }
                else if (key < array[mid])
                {
                    return MyBinarySearch(array, key, min, mid - 1);
                }
                else
                {
                    return MyBinarySearch(array, key, mid + 1, max);
                }
            }
            
        }

    }
}
