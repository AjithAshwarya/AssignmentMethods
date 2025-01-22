using FibonacciGeneratorApp.Model;

namespace ConsoleAppFibonacci
{
    internal class FibonacciProgram
    {
        static void Main(string[] args)
        {
            // Instance of the FibonacciGenerator class
            FibonacciGenerator fibonacciGenerator = new FibonacciGenerator();

            // Prompt the user for the number of Fibonacci numbers to display
            Console.WriteLine("Enter the number of Fibonacci numbers to display:");
            int n = int.Parse(Console.ReadLine());

            // Validate input
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive integer greater than 0.");
            }
            else
            {
                // Display the Fibonacci sequence using the DisplayFibonacci method
                fibonacciGenerator.DisplayFibonacci(n);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}