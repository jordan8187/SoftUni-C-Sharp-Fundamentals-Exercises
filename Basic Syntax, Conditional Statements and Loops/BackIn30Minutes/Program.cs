using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;
            if (minutes >= 60)
            {
                minutes -= 60;
                hours += 1;
            }
            if (hours >= 24)
            {
                hours -= 24;
            }
            string finalMinutes = minutes.ToString();
            if (finalMinutes[0] != '0' && minutes < 10)
            {
                string newFinalMinutes = $"0{minutes}";
                Console.WriteLine($"{hours}:{newFinalMinutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{finalMinutes}");
            }
        }
    }
}
