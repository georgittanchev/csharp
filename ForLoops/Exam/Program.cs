using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
      
            double foodMoney = double.Parse(Console.ReadLine());
            double souvenirMoney = double.Parse(Console.ReadLine());
            double hotelMoney = double.Parse(Console.ReadLine());


            double gasolinePrice = 4.2 * 7 * 1.85;
            

            double finalHotelMoney1 = hotelMoney * 0.9;
            double finalHotelMoney2 = hotelMoney * 0.85;
            double finalHotelMoney3 = hotelMoney * 0.80;
            double finalFinalHotelMoney = finalHotelMoney1 + finalHotelMoney2 + finalHotelMoney3;

            double daysMoney = (3 * souvenirMoney) + (3 * foodMoney);




            double finalMoney = gasolinePrice + finalFinalHotelMoney + daysMoney;

            Console.WriteLine($"Money needed: {finalMoney:f2}");






        }
    }
}
