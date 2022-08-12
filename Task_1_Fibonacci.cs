using System;
using System.Collections.Generic;

namespace Task_1_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                var firstNumber = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var secondNumber = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(firstNumber + secondNumber);
            }
            foreach (var item in fibonacciNumbers)
                Console.Write(item + " ");
        }
    }
}
