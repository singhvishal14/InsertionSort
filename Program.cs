using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInsertionSort
{
    internal class Program
    {
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for(int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j+1]= arr[j];
                    j--;
                }
                arr[j+1] = key;
              
            }

        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  "); // Changed WriteLine to Write to print on the same line.
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            int[] arr = { 9,5,1,4,3};
            Console.WriteLine("array without Insertion sort");
            Print(arr);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            InsertionSort(arr);
            stopwatch.Stop();   

            Console.WriteLine("array with Insertion sort");
            Print(arr);

            Console.WriteLine($"Arraysize {arr.Length} Time taken {stopwatch.Elapsed.TotalMilliseconds} miliseconds");
            Console.ReadLine();
        }
    }
    }
