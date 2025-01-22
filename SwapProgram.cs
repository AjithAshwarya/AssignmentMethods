using ValueSwapperApp.Model;

namespace ConsoleAppValueSwap
{
   
        internal class SwapProgram
        {
            static void Main(string[] args)
            {
                // Instance of the ValueSwapper class
                ValueSwapper swapper = new ValueSwapper();

                // Prompt the user to enter two numbers
                Console.WriteLine("Enter the first number:");
                int firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int secondNumber = int.Parse(Console.ReadLine());

                // Display the original values
                Console.WriteLine($"Before swapping: First Number = {firstNumber}, Second Number = {secondNumber}");

                // Swap the values using the SwapValues method
                swapper.SwapValues(ref firstNumber, ref secondNumber);

                // Display the swapped values
                swapper.DisplaySwappedValues(firstNumber, secondNumber);

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }


