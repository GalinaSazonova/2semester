using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace TicTacToeWillWork
{
    /// <summary>
    /// Class for computer's strategy.
    /// </summary>
    public class ComputerMoves
    {
        /// <summary>
        /// Function, that decides, where should toe be, does not make unwinnable moves
        /// </summary>
        /// <param name="crossArr"></param>
        /// <param name="allCellsArr"></param>
        /// <param name="toeArr"></param>
        /// <returns></returns>
        public int PutToe(bool[] crossArr, bool[] allCellsArr, bool[] toeArr)  
        {
            if (Urgent(toeArr, allCellsArr) != -1)
                return Urgent(toeArr, allCellsArr);
            if (Urgent(crossArr, allCellsArr) != -1)
                return Urgent(crossArr, allCellsArr);
            if (NoObviousMoves(crossArr, allCellsArr, toeArr) != -1)
                return NoObviousMoves(crossArr, allCellsArr, toeArr);
            return -1;
        }

        private int Urgent(bool[] SignArr, bool[] allCellsArr)
        {
            int check = -1;
            for (int i = 0; i < 3; i++)
            {
                check = CountPlace(SignArr, allCellsArr, i * 3, i * 3 + 1, i * 3 + 2);
                if (check != -1)
                    return check;
                check = CountPlace(SignArr, allCellsArr, i % 3, i % 3 + 3, i % 3 + 6);
                if (check != -1)
                    return check;
            }
            check = CountPlace(SignArr, allCellsArr, 0, 4, 8);
            if (check != -1)
                return check;
            check = CountPlace(SignArr, allCellsArr, 2, 4, 6);
            if (check != -1)
                return check;
            return check;
        }

        private int CountPlace(bool[] SignArr, bool[] allCellsArr, int a, int b, int c)
        {
            if (SignArr[a] && SignArr[a] == SignArr[b] && !allCellsArr[c])
                return c;
            if (SignArr[a] && SignArr[a] == SignArr[c] && !allCellsArr[b])
                return b;
            if (SignArr[b] && SignArr[c] == SignArr[b] && !allCellsArr[a])
                return a;
            return -1;
        }

        private int NoObviousMoves(bool[] crossArr, bool[] allCellsArr, bool[] toeArr)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!allCellsArr[i])
                {
                    toeArr[i] = true;
                    allCellsArr[i] = true;
                    int temp = Urgent(toeArr, allCellsArr);
                    if (temp != -1)
                    {
                        toeArr[i] = false;
                        allCellsArr[i] = false;
                        return temp;
                    }
                    toeArr[i] = false;
                    allCellsArr[i] = false;
                    if (!allCellsArr[4])
                    {
                        return 4;
                    }
                    if (i % 2 == 1 && crossArr[0] && crossArr[0] == crossArr[8] && !allCellsArr[i])
                    {
                        return i;
                    }
                    if (i % 2 == 1 && crossArr[2] && crossArr[6] == crossArr[2] && !allCellsArr[i])
                    {
                        return i;
                    }
                    if (allCellsArr[4] && crossArr[4])
                    {
                        if (i % 2 == 0 && !allCellsArr[i])
                        {
                            return i;
                        }
                    }
                    return i;
                }
            }
            return -1;
        }
    }
}
