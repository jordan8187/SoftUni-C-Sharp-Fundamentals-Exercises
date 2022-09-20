using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string group = string.Empty;
            if (age >= 0 && age <= 2)
            {
                group = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                group = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                group = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                group = "adult";
            }
            else if (age >= 66)
            {
                group = "elder";
            }
            Console.WriteLine($"{group}");
        }
    }
}
