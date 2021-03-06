﻿using System;

namespace MyNameSpace
{
    /// <summary>
    /// User enter size of array, it fills with random numbers  and appears on console, then sorting, and appears resut of sort
    /// </summary>
    class Program
    {
        /// <summary>
        /// Sorting array from bigger to smaller
        /// </summary>
        /// <param name="arr">Array to sort</param>
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < arr.Length - 1; ++j)
                {
                    if (arr[j + 1] > arr[j])
                    {
                        int x = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = x;
                    }
                }
            }
        }

        /// <summary>
        /// Print array on console
        /// </summary>
        /// <param name="arr">Array to print</param>
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("{0}, ", arr[i]);
            }
            System.Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            System.Console.WriteLine("Please, enter size of an array");
            int arrSize = System.Int32.Parse(System.Console.ReadLine());
            int[] arr = new int[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                arr[i] = random.Next(10, 99);
            }
            PrintArray(arr);
            BubbleSort(arr);
            PrintArray(arr);
        }
    }
}
