using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorialSum = 0;
            int number = int.Parse(Console.ReadLine());
            int numberToDivide = number;
            int factorial = 1;
            int factorialNumber = 0;
            while (numberToDivide > 0)
            {
                factorialNumber = numberToDivide % 10;
                numberToDivide /= 10;
                for (int factorialCount = 1; factorialCount <= factorialNumber; factorialCount++)
                {
                    if (factorialNumber == 0)
                    {
                        break;
                    }
                    else
                    {
                        factorial *= factorialCount;
                    }
                }
                factorialSum += factorial;
                factorial = 1;
            }
            if (factorialSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}

            // offsets[10 + 1] = {

             //   0, 0, 3,6,9,....27,30
             // }
             //letters[25] ={ 
             //  ' ','a', 'b', 
