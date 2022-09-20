using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double travelerCount = double.Parse(Console.ReadLine());
            string travelerGroupType = Console.ReadLine();
            string travelDay = Console.ReadLine();
            double pricePerTraveler = 0.0;
            double totalPrice = 0.0;
            travelerCount = travelerCount * 1.0;
            if (travelerGroupType == "Students" && travelDay == "Friday")
            {
                pricePerTraveler = 8.45;
            }
            else if (travelerGroupType == "Students" && travelDay == "Saturday")
            {
                pricePerTraveler = 9.80;
            }
            else if (travelerGroupType == "Students" && travelDay == "Sunday")
            {
                pricePerTraveler = 10.46;
            }
            else if (travelerGroupType == "Business" && travelDay == "Friday")
            {
                pricePerTraveler = 10.90;
            }
            else if (travelerGroupType == "Business" && travelDay == "Saturday")
            {
                pricePerTraveler = 15.60;
            }
            else if (travelerGroupType == "Business" && travelDay == "Sunday")
            {
                pricePerTraveler = 16.0;
            }
            else if (travelerGroupType == "Regular" && travelDay == "Friday")
            {
                pricePerTraveler = 15.0;
            }
            else if (travelerGroupType == "Regular" && travelDay == "Saturday")
            {
                pricePerTraveler = 20.0;
            }
            else if (travelerGroupType == "Regular" && travelDay == "Sunday")
            {
                pricePerTraveler = 22.50;
            }

            totalPrice = pricePerTraveler * travelerCount;

            if (travelerGroupType == "Students" && travelerCount >= 30)
            {
                totalPrice = totalPrice * 0.85;
            }
            else if (travelerGroupType == "Business" && travelerCount >= 100)
            {
                totalPrice = totalPrice - 10.0 * pricePerTraveler;
            }
            else if (travelerGroupType == "Regular" && travelerCount >= 10 && travelerCount <= 20)
            {
                totalPrice = totalPrice * 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
