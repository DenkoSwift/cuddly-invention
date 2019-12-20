using System;

namespace maxMinArrays
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int max = new int();
            int min = new int();
            int maxIndex = new int();
            int minIndex = new int();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0}:", i);
                arr[i] = int.Parse(Console.ReadLine());
            }


           

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }

            }
            Console.WriteLine("The max value is {0} and its index is on number {1} ", max, maxIndex);
            Console.WriteLine("The min value is {0} and its index is on number {1} ", min, minIndex);
            Console.ReadKey();
        }
    }
}

