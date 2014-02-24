
namespace ConsoleApplication1
{
    class Program
    {
        public static double Factorial (int n)
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
