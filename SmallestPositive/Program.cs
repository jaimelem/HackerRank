using System;
using System.Collections.Generic;

namespace SmallestPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            //var r = solution(new int[] { 1, 3, 6, 4, 1, 2, 8 }); // = 5
            //var r = solution(new int[] { 1, 2, 3 }); // = 4
            //var r = solution(new int[] { -1, -2 }); // = 1
            var r = solution(new int[] { -1, -2, 1, 3, 4, -8 }); // = 1

            Console.WriteLine(r);
        }

        public static int solution(int[] A)
        {
            Array.Sort(A);
            List<int> aux = new List<int>();
            int result;


            //Caso en el no existe continuidad
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] <= 0)
                {
                    aux.Add(1);
                    break;
                }
                else
                {
                    int diff = A[i + 1] - A[i];

                    if (diff > 1)
                    {
                        aux.Add(A[i] + 1);
                    }
                }
            }

            //Si la lista es igual que cero entonces si existe continuidad. Se suma un 1 al último elemento
            if (aux.Count == 0)
            {
                aux.Add(A[A.Length - 1] + 1);
            }


            aux.Sort();

            return aux[0];
        }
    }
}
