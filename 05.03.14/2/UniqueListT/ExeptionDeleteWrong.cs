using System;

namespace UniqueListT
{
    /// <summary>
    /// Exeprion when try to delete value, which is not in list
    /// </summary>
    [Serializable]
    public class ExeptionDeleteWrong : Exception
    {
        /// <summary>
        /// Exeption with message.
        /// </summary>
        public ExeptionDeleteWrong()
        {
            Console.WriteLine("This element does not exist.");
        }
    }
}
