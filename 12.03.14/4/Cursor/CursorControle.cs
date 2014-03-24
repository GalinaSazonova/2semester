using System;

namespace Cursor
{
    /// <summary>
    /// Controle cursor movements class.
    /// </summary>
    public class CursorControle
    {
        /// <summary>
        /// Cursor on the left and draws line.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnLeft(object sender, EventArgs args)
        {
            if (Console.CursorLeft != 0)
            {
                Console.CursorLeft--;
                Console.Write("_");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                
            }
        }

        /// <summary>
        /// Cursor on the right and draws line.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnRight(object sender, EventArgs args)
        {
            if (Console.CursorLeft < Console.BufferWidth - 2)
            {
                Console.Write("_");
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); // notice: +1 is not here now
                               
            }
        }

        /// <summary>
        /// Cursor up and draws line.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnUp(object sender, EventArgs args)
        {
            if (Console.CursorTop != 0)
            {
                Console.Write("|"); 
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1); // notice: -1 added to left
                               
            }
        }

        /// <summary>
        /// Cursor down and draws line.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDown(object sender, EventArgs args)
        {
            if (Console.CursorTop < Console.BufferHeight - 1)
            {
                Console.CursorTop++;
                Console.Write("|");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // notice: -1 added, +1 out
            }
        }
    }
    }

