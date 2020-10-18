using System;
namespace _16.Time15Minutes
{
    class Time15Minutes
    {
        static void Main()
        {
            /*Да се напише програма, която чете час и минути от 24-часово денонощие, въведени от потребителя и
изчислява колко ще е часът след 15 минути. Резултатът да се отпечата във формат часове:минути. Часовете
винаги са между 0 и 23, а минутите винаги са между 0 и 59. Часовете се изписват с една или две цифри.
Минутите се изписват винаги с по две цифри, с водеща нула, когато е необходимо.*/

            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            double minutesAdditional = minutes + 15;

            if (minutesAdditional > 59)
            {
                hours += 1;
                minutesAdditional -= 60;
            }

            if (hours >= 24)
            {
                hours -= 24;
            }
            if (minutesAdditional < 10)
            {
                Console.WriteLine($"{hours}:0{minutesAdditional}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutesAdditional}");
            }


        }
    }
}
