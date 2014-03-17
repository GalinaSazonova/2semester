namespace StackCalcul
{
    /// <summary>
    /// Interface for stack with maun functions.
    /// </summary>
    public interface StackInterface
    {
        /// <summary>
        /// Push value to a stack.
        /// </summary>
        /// <param name="value">Value to be pushed.</param>
        void Push(int value);

        /// <summary>
        /// Returns head value 
        /// </summary>
        int Pop();

        /// <summary>
        /// Check if stack is empty
        /// </summary>
        /// <returns>True if empty & vc</returns>
        bool IsEmpty();

        /// <summary>
        /// Print stack on console
        /// </summary>
        void PrintStack();

        /// <summary>
        /// Makes stack empty
        /// </summary>
        void ClearStack();
    }
}
