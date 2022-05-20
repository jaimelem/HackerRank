using System;
using System.Collections.Generic;

namespace FindTheMedian
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());


            List<int> arr = new List<int>();

            for (int i = 0; i < arrayLength; i++)
            {
                arr.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(FindMedian(arr));
        }

        private static int FindMedian(List<int> arr)
        {
            if (arr.Count % 2 == 0)
            {
                arr.Add(0);
            }

            int sum = 0;

            arr.Sort();

            for (int i = 0; i < arr.Count; i++)
            {
                sum = arr[i] + sum;
            }

            return sum / arr.Count;
        }
    }
}
