using System;
namespace _17.OnTimeForExam
{
    class OnTimeForExam
    {
        static void Main()
        {
           
            double examHour = double.Parse(Console.ReadLine());
            double examMinute = double.Parse(Console.ReadLine());
            double arrivalHour = double.Parse(Console.ReadLine());
            double arrivalMinute = double.Parse(Console.ReadLine());


            examHour *= 60;
            arrivalHour *= 60;

            double arrivalTime = arrivalHour + arrivalMinute;
            double examTime = examHour + examMinute;

            double difference = examTime - arrivalTime;

            examHour /= 60;
            examMinute %= 60;
            arrivalHour /= 60;
            arrivalMinute %= 60;



            if (difference > -1)
            {
                if (difference > -59)
                {

                    Console.WriteLine("Late");
                    Console.WriteLine($" minutes after the start");
                }

            }







        }
    }
}
