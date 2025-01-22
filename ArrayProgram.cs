using ArraySumCalculatorApp.Model;

namespace ConsoleAppArraySum
{
    
        internal class ArrayProgram
        {
            static void Main(string[] args)
            {
            // Instance of the ArraySumCalculator class
            ArraySumCalculator sumCalculator = new ArraySumCalculator();

                // Prompt the user for the number of elements in the array
                Console.WriteLine("Enter the number of elements in the array:");
                int size = int.Parse(Console.ReadLine());

                // Create an array to store the elements
                int[] numbers = new int[size];

                // Prompt the user to input each element
                Console.WriteLine("Enter the elements of the array:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Element {i + 1}: ");
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                // Display the sum of the array elements using the DisplaySum method
                sumCalculator.DisplaySum(numbers);

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }


