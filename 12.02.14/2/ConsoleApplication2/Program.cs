
namespace ConsoleApplication2
{
    /// <summary>
    /// User enter a position of nesessary number, and that meaning appears on console
    /// </summary>
    class Program
    {
        /// <summary>
        /// Count the fibonacci number by position
        /// </summary>
        /// <param name="n">Position of number user needs</param>
        /// <returns>Meaning of fibonacci number on nesessary position</returns>
        public static double Fibonacci(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Please, enter a number");
            int n = System.Int32.Parse(System.Console.ReadLine());
            if (n >= 0)
            {
                double fib = Fibonacci(n);
                System.Console.WriteLine("Mean of n's number is = {0}", fib);
            }
            else
            {
                System.Console.WriteLine("Wrong value");
            }
        }
    }
}
