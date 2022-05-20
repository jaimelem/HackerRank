using System;
using System.Collections.Generic;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 };
            miniMaxSum(r);
        }

        public static void miniMaxSum(List<int> arr)
        {
            var aux = new List<long>();

            for (int i = 0; i < arr.Count; i++)
            {
                long sum = 0;

                for (int j = 0; j < arr.Count; j++)
                {
                    if (j != i)
                    {
                        sum = arr[j] + sum;
                    }
                }

                aux.Add(sum);
            }

            aux.Sort();
            Console.WriteLine($"{aux[0]} {aux[^1]}");
        }
    }
}
