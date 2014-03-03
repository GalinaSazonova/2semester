using System;

namespace masSortByColl
{
    class Program
    {
        public static void PrintTwoDimArray(int[,] arr, int arrSizeCol, int arrSizeLines)
        {
            for (int i = 0; i < arrSizeLines; i++)
            {
                for (int j = 0; j < arrSizeCol; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void ChangeTwoColl(ref int[,] arr, int arrSizeLines,  int firstToCh, int secToCh)
        {
            for (int i = 0; i < arrSizeLines; i++)
            {
                int temp = arr[i, firstToCh];
                arr[i, firstToCh] = arr[i, secToCh];
                arr[i, secToCh] = temp;
            }
        }

        public static void SortArrByFirstColEl(ref int[,] arr, int arrSizeCol, int arrSizeLines)
        {
            for (int i = 0; i < arrSizeCol; ++i)
           {
                 for (int j = 0; j < arrSizeCol - 1; ++j)
                 {
                     if (arr[0, j + 1] > arr[0, j])
                     {
                         ChangeTwoColl(ref arr, arrSizeLines, j, j + 1);
                     }
                 }
             }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Please, enter array size, firstly collons, secondly lines");
            int arrSizeCol = System.Int32.Parse(System.Console.ReadLine());
            int arrSizeLines = System.Int32.Parse(System.Console.ReadLine());
            int[,] arr = new int[arrSizeLines, arrSizeCol];
            for (int i = 0; i < arrSizeLines; i++)
            {
                for (int j = 0; j < arrSizeCol; j++)
                {
                    arr[i, j] = random.Next(10, 99);
                }
            }
            PrintTwoDimArray(arr, arrSizeCol, arrSizeLines);
            Console.WriteLine();
            SortArrByFirstColEl(ref arr, arrSizeCol, arrSizeLines);
            PrintTwoDimArray(arr, arrSizeCol, arrSizeLines);
        }
    }
}
