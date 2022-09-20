using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            int oddNumberSum = 0;
            for (int numbersFound = 0; numbersFound < n; number++)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                    numbersFound++;
                    oddNumberSum += number;
                }
            }
            Console.WriteLine($"Sum: {oddNumberSum}");
        }
    }
}
