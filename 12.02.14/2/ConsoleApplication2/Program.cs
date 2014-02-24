
namespace ConsoleApplication2
{
    class Program
    {
        public static double Fibbon(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return Fibbon(n - 1) + Fibbon(n - 2);
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Please, enter a number");
            int n = System.Int32.Parse(System.Console.ReadLine());
            if (n >= 0)
            {
                double fib = Fibbon(n);
                System.Console.WriteLine("Mean of n's number is = {0}", fib);
            }
            else
            {
                System.Console.WriteLine("Wrong value");
            }
        }
    }
}
