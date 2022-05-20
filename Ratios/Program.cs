using System;
using System.Collections.Generic;

namespace Ratios
{
    class Program
    {
        static void Main(string[] args)
        {
            //var data = new List<int> { -4, 3, -9, 0, 4, 1 };
            var data = new List<int> { 0, 0, -1, 1, 1 };
            plusMinus(data);
        }

        public static void plusMinus(List<int> arr)
        {
            var data = new int[3];

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {                    
                    data[0] = data[0] + 1;
                } 
                else if (arr[i] < 0)
                {
                    data[1] = data[1] + 1;
                } 
                else if (arr[i] == 0)
                {
                    data[2] = data[2] + 1;
                }
            }

            for (int i = 0; i < data.Length; i++)
            {
                var result = data[i] / (decimal)arr.Count;
                Console.WriteLine(string.Format("{0:0.000000}", result));
            }
        }
    }
}
