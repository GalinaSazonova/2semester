using System;

namespace masSortByColl
{
    class Program
    {
        /// <summary>
        /// Print two dim array
        /// </summary>
        /// <param name="arr">Array to print</param>
        /// <param name="arrSizeColumns">Size of array</param>
        public static void PrintTwoDimArray(int[,] arr, int arrSizeColumns, int arrSizeLines)
        {
            for (int i = 0; i < arrSizeLines; i++)
            {
                for (int j = 0; j < arrSizeColumns; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Changes two columns places
        /// </summary>
        /// <param name="arr">Array, where we need changes</param>
        /// <param name="arrSizeLines">Number of lines in array</param>
        /// <param name="firstToChange">Number of first column</param>
        /// <param name="secondToChange">Number of secondcolumn</param>
        public static void ChangeTwoColumns(ref int[,] arr, int arrSizeLines,  int firstToChange, int secondToChange)
        {
            for (int i = 0; i < arrSizeLines; i++)
            {
                int temp = arr[i, firstToChange];
                arr[i, firstToChange] = arr[i, secondToChange];
                arr[i, secondToChange] = temp;
            }
        }

        /// <summary>
        /// Sort array by first elements in colums
        /// </summary>
        /// <param name="arr">Array to sort</param>
        /// <param name="arrSizeColumns">Number of columns in array</param>
        /// <param name="arrSizeLines">Number of lines in array</param>
        public static void SortArrByFirstColEl(ref int[,] arr, int arrSizeColumns, int arrSizeLines)
        {
            for (int i = 0; i < arrSizeColumns; ++i)
           {
                 for (int j = 0; j < arrSizeColumns - 1; ++j)
                 {
                     if (arr[0, j + 1] > arr[0, j])
                     {
                         ChangeTwoColumns(ref arr, arrSizeLines, j, j + 1);
                     }
                 }
             }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Please, enter array size, firstly collons, secondly lines");
            int arrSizeColumns = System.Int32.Parse(System.Console.ReadLine());
            int arrSizeLines = System.Int32.Parse(System.Console.ReadLine());
            int[,] arr = new int[arrSizeLines, arrSizeColumns];
            for (int i = 0; i < arrSizeLines; i++)
            {
                for (int j = 0; j < arrSizeColumns; j++)
                {
                    arr[i, j] = random.Next(10, 99);
                }
            }
            PrintTwoDimArray(arr, arrSizeColumns, arrSizeLines);
            Console.WriteLine();
            SortArrByFirstColEl(ref arr, arrSizeColumns, arrSizeLines);
            PrintTwoDimArray(arr, arrSizeColumns, arrSizeLines);
        }
    }
}
