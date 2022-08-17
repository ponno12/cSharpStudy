using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.nadongbin.Binary
{
    public class BinarySearch
    {
        public void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int answer = (int)BinarySearchIterative(array, 9);
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
        public static object MyBinarySearchRecursive(int[] array, int key, int min, int max)
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
                    return MyBinarySearchRecursive(array, key, min, mid - 1);
                }
                else
                {
                    return MyBinarySearchRecursive(array, key, mid + 1, max);
                }
            }

        }

        public static object MyBinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                var mid = (min + max) / 2;
                var val = inputArray[mid];
                if (val == key)
                {
                    return ++mid;
                }
                else if (key < val)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "null";
        }

    }
}
