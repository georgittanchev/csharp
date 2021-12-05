using System;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {


            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int after = minutes + 15;

            if (after >= 60)
            {
                hours += 1;
                after -= 60;
            }
            if (hours > 23)
            {
                hours -= 24;
            }

            if (after < 10)
            {
                Console.WriteLine($"{hours}:0{after}");
            }
            else
            {
                Console.WriteLine($"{hours}:{after}");
            }
           












        }
    }
}
