using StringSpaceCounterApp.Model;

namespace StringSpaceCounterApp
{
    internal class SpaceProgram
    {
        static void Main(string[] args)
        {
            // Instance of the StringSpaceCounter class
            StringSpaceCounter spaceCounter = new StringSpaceCounter();

            // Prompt the user for a string
            Console.WriteLine("Enter a string:");
            string userInput = Console.ReadLine();

            // Display the result using the DisplaySpaceCount method
            spaceCounter.DisplaySpaceCount(userInput);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

