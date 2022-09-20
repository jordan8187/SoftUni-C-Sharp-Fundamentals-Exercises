using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double johnMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double singlelightsaberPrice = double.Parse(Console.ReadLine());
            double singlerobePrice = double.Parse(Console.ReadLine());
            double singlebeltPrice = double.Parse(Console.ReadLine());
            double totalbeltPrice = singlebeltPrice * students - singlebeltPrice*(students / 6);
            double totalPrice = singlelightsaberPrice * Math.Ceiling(students * 1.1) + singlerobePrice * students + totalbeltPrice*1.00;
            if (johnMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                double neededMoney = Math.Abs(johnMoney - totalPrice);
                Console.WriteLine($" John will need {neededMoney:F2}lv more.");
            }

        }
    }
}
