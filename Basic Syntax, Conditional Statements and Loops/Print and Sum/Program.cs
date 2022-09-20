using System;

namespace Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; start <= end; i++)
            {
                if (start != end)
                {
                    Console.Write($"{start} ");
                }
                else
                {
                    Console.WriteLine($"{start}");
                }
                sum = sum + start;
                start++;

            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
