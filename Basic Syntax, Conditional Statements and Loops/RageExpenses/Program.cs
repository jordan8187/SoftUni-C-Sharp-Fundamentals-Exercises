using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double headsetsDestroyed = gamesLost / 2;
            double miceDestroyed = gamesLost / 3;
            double keyboardsDestroyed = gamesLost / 6;
            double displayesDestroyed = gamesLost / 12;
            double destructionExpenses = headsetsDestroyed * headsetPrice + miceDestroyed * mousePrice + keyboardsDestroyed * keyboardPrice + displayesDestroyed * displayPrice;
            Console.WriteLine($"Rage expenses: {destructionExpenses:F2} lv.");

        }
    }
}
