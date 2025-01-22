using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciGeneratorApp.Model
{
    public class FibonacciGenerator //class namespace
    {
        // Default constructor
        public FibonacciGenerator() { }

        // Method to generate the Fibonacci sequence
        public int[] GenerateFibonacci(int n)
        {
            int[] fibonacciSequence = new int[n];

            if (n >= 1) fibonacciSequence[0] = 0; // First Fibonacci number
            if (n >= 2) fibonacciSequence[1] = 1; // Second Fibonacci number

            for (int i = 2; i < n; i++)
            {
                fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
            }

            return fibonacciSequence;
        }

        // Method to display the Fibonacci sequence
        public void DisplayFibonacci(int n)
        {
            int[] sequence = GenerateFibonacci(n);

            Console.WriteLine($"The first {n} numbers in the Fibonacci sequence are:");
            foreach (int num in sequence)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); // For a new line after the sequence
        }
    }
}


