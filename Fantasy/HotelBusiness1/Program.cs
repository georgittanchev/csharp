using System;

namespace HotelBusiness1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Хотел има 12 двойни стаи. Да се изчисли каква е крайната печалба от хотела, ако се знае, че всички стаи са заети
            //     90% от годината, разходите са 40% от оборота.Всяка единична стая струва 68.00лв. с вкл. закуска
            //Всяка двойна стая струва 75.00лв. на нощувка с вкл. закуска, като всяка
            //     от тях има възможност за тройно и четворно ползване.
            // Единично настаняване има в 53% от случаите, двойно има в 37% от случаите, тройното има 6%, а четворното 4%.
            //     Всяко тройно настаняване се таксува по 100.00лв. на нощувка, а всяко четворно по 125.00лв.
            // Комисионната на Booking е 20%, всеки 10% от резервациите са от Booking.
            // Наема на хотела е 5000лв.


            double maximumCapacity = 30 * 12;
            double realCapacity = maximumCapacity * 0.9;
            double bookingReservation = Math.Floor(realCapacity * 0.1);

            double cashIncome0 = ((realCapacity * 68) * 0.55) - bookingReservation;
            double cashIncome1 = ((realCapacity * 75) * 0.37) - bookingReservation;
            double cashIncome2 = ((realCapacity * 100) * 0.06) - bookingReservation;
            double cashIncome3 = ((realCapacity * 125) * 0.04) - bookingReservation;

            double finalIncome = ((cashIncome0 + cashIncome1 + cashIncome2 + cashIncome3) * 0.6) - 5000;
            Console.WriteLine();
            Console.WriteLine($"Крайната печалба на хотел Фаня е: {finalIncome:F2}лв. / на месец");

            int counter = 0;
            double monthPassed = 0;
            double months = double.MaxValue;
            double finaFinalAmount = 0;

            while (counter < months)
            {
                Console.WriteLine($"Изминали месеци:");

                monthPassed = double.Parse(Console.ReadLine());

                Console.WriteLine($"Общо печалба:");

             

                double finalAmmount = monthPassed * finalIncome;

                finaFinalAmount += finalAmmount;

                Console.WriteLine($"{finaFinalAmount:F2}");

                counter++;
            }

            

        }
    }
} 
