using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungLopStopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();
            stopWatch.Reset();
            stopWatch.Start();
            SelectionSort();
            stopWatch.Stop();
            stopWatch.GetElapsedTimePerMillisecond();
            Console.WriteLine("\nRunTime: " + stopWatch.elapsedTime);
        }

        static void SelectionSort()
        {
            Random random = new Random();
            int[] arr = new int[100000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100000);
            }

            Console.WriteLine("====================================================================================================");
            Console.WriteLine("Initial array is: ");
            Console.WriteLine("====================================================================================================");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Array.Sort(arr);

            Console.WriteLine();
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("Sorted array is: ");
            Console.WriteLine("====================================================================================================");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
