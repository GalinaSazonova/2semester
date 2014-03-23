using System;

namespace UniqueListT
{
    /// <summary>
    /// Exeption when try to add already exist element.
    /// </summary>
    [Serializable]
    public class ExeptionAlreadyExist : Exception
    {
        /// <summary>
        /// Exeption with message.
        /// </summary>
        public ExeptionAlreadyExist()
        {
            Console.WriteLine("Element is in list already");
        }
    }
}
