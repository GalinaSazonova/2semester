using System;

namespace arrSpiral
{
    public class Program
    {
        /// <summary>
        /// Does spiral walk in two-dim array and writes values in nessesary order to one-dim array
        /// uses check-value prevStep
        /// 0 - beginning;
        /// 1 - to the right
        /// 2 - down
        /// 3 - to the left
        /// 4 - up
        /// </summary>
        /// <param name="arr">two-dim array, we need to work with</param>
        /// <param name="arrSize"></param>
        /// <param name="helpArr">array to keep values</param>
       
        public static void SpiralWalk(int[,] arr, int arrSize, ref int[] helpArr)
        {
            int begElementPlace = arrSize / 2;
            int nextElI = -1;
            int nextElJ = -1;
            int placeInHelpArr = 0;
            int prevStep = 0;
            while (placeInHelpArr < arrSize * arrSize && nextElI < arrSize && nextElJ < arrSize)
            {
                if (prevStep == 0)
                {
                    helpArr[placeInHelpArr] = arr[begElementPlace, begElementPlace];
                    nextElI = begElementPlace;
                    nextElJ = begElementPlace + 1;
                    placeInHelpArr++;
                    prevStep = 1;
                    continue;
                }
                if (prevStep == 1)
                {
                    if (nextElI + nextElJ == arrSize)
                    {
                        helpArr[placeInHelpArr] = arr[nextElI, nextElJ];
                        nextElI++;
                        placeInHelpArr++;
                        prevStep = 2;
                        continue;
                    }
                    else
                    {
                        helpArr[placeInHelpArr] = arr[nextElI, nextElJ];
                        nextElJ++;
                        placeInHelpArr++;
                        prevStep = 1;
                        continue;
                    }
                }
                if (prevStep == 2)
                {
                    if (nextElJ == nextElI)
                    {
                        helpArr[placeInHelpArr] = arr[nextElI, nextElJ];
                        nextElJ--;
                        placeInHelpArr++;
                        prevStep = 3;
                        continue;
                    }
                    else
                    {
                        helpArr[placeInHelpArr] = arr[nextElI, nextElJ];
                        nextElI++;
                        placeInHelpArr++;
                        prevStep = 2;
                        continue;
                    }
                }
                if (prevStep == 3)
                {
                    if (nextElJ + nextElI == arrSize - 1)
                    {
                        helpArr[placeInHelpArr] = arr[nextElI, nextElJ];
                        nextElI--;
                        placeInHelpArr++;
                        prevStep = 4;
                        continue;
                    }
                    else
                    {
                        helpArr[placeInHelpArr] = arr[nextElI, nextElJ];
                        nextElJ--;
                        placeInHelpArr++;
                        prevStep = 3;
                        continue;
                    }
                }
                if (prevStep == 4)
                {
                    if (nextElI == nextElJ)
                    {
                        helpArr[placeInHelpArr] = arr[nextElI, nextElJ];
                        nextElJ++;
                        placeInHelpArr++;
                        prevStep = 1;
                        continue;
                    }
                    else
                    {
                        helpArr[placeInHelpArr] = arr[nextElI, nextElJ];
                        nextElI--;
                        placeInHelpArr++;
                        prevStep = 4;
                        continue;
                    }
                }
            }
        }

        public static void PrintOneDimArray(int[] arr)
        {
           for (int i = 0; i < arr.Length; i++)
           {
               Console.Write("{0}, ", arr[i]);
           }
           Console.WriteLine();
        }

        public static void PrintTwoDimArray(int[,] arr, int arrSize)
        {
            for (int i = 0; i < arrSize; i++)
            {
                for (int j = 0; j < arrSize; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Please, enter array size");
            int arrSize = System.Int32.Parse(System.Console.ReadLine());
            if (arrSize % 2 == 0)
            {
                Console.WriteLine("Wrong value");
            }
            else
            {
                Console.WriteLine("Good work");
                int[,] arr = new int[arrSize, arrSize];
                for (int i = 0; i < arrSize; i++)
                {
                    for (int j = 0; j < arrSize; j++)
                    {
                        arr[i, j] = random.Next(10, 99);
                    }
                }
                PrintTwoDimArray(arr, arrSize);
                int[] helpArr = new int[arrSize * arrSize];
                SpiralWalk(arr, arrSize, ref helpArr);
                PrintOneDimArray(helpArr);
            }
        }
    }
}
