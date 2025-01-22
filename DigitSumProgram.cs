using DigitSumApp.Model;

namespace ConsoleAppDigitSum
{
    internal class DigitSumProgram
    {
        static void Main(string[] args)
        {
            // Instance of the DigitSumCalculator class
            DigitSumCalculator digitSumCalculator = new DigitSumCalculator();

            // Prompt the user for a number
            Console.WriteLine("Enter a number to calculate the sum of its digits:");
            int number = int.Parse(Console.ReadLine());

            // Display the digit sum using the DisplayDigitSum method
            digitSumCalculator.DisplayDigitSum(number);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
