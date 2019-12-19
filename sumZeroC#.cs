using System;

namespace algorithamExercise
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("Number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            int counter = 0;


            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0} : ",i);
                arr[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < n; i++)
            {
                if(arr[i] == 0)
                {


                    counter++;
                }
                sum += arr[i];
            }

            Console.WriteLine("The sum is: {0}",sum);
            Console.WriteLine("The zero elements in the array are: {0}",counter);
            Console.ReadKey();
            
        }
    }
}
