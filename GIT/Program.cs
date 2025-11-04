
namespace GIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int a = 1;
            int b = 2;
            Sum(a, b);
        }

        private static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
