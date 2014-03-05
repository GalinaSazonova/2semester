
namespace ConsoleApplication1
{
    /// <summary>
    /// User enter a number, he want to know a factorial, and that meaning appears on console
    /// </summary>
    class Program
    {
        /// <summary>
        /// Count the meaning of factiorial
        /// </summary>
        /// <param name="n">Number to count</param>
        /// <returns>Meaning of factiorial of n</returns>
        public static double Factorial(int n)
        {
            return n <= 1 ? 1 : n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Please, enter a value");
            int n = System.Int32.Parse(System.Console.ReadLine());
            if (n >= 0)
            {
                double fact = Factorial(n);
                System.Console.WriteLine("Factorial of n = {0}", fact);
            }
            else
            {
                System.Console.WriteLine("Wrong value");
            }
        }
    }
}
