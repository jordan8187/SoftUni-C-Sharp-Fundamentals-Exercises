using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double totalOrdersPrice = 0;
            for (int i = 0; i < orders; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                double orderPrice = capsulePrice * days * capsuleCount;
                totalOrdersPrice += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
            }
            Console.WriteLine($"Total: ${totalOrdersPrice:F2}");
        }
    }
}
