using System;

namespace NumberTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int coreNumber = int.Parse(Console.ReadLine());
            for(int row = 1; row <= coreNumber; row++)
            {
                for (int nCount = 1; nCount <= row; nCount++)
                {
                    Console.Write($"{row} ");
                }
                if (row != coreNumber)
                {
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
