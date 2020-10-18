using System;

namespace _15.Walking
{
    class Program
    {
        static void Main(string[] args)
        {

            //            Габи иска да започне здравословен начин на живот и си е поставила за цел да върви 10 000 
            //                стъпки всеки ден.Някои дни обаче е много уморена от работа и ще иска да се прибере преди да
            //                постигне целта си.Напишете програма, която чете от конзолата по колко стъпки изминава тя всеки път 
            //                като излиза през деня и когато постигне целта си да се изписва "Goal reached! Good job!"
            //Ако иска да се прибере преди това, тя ще въведе командата "Going home" и ще въведе стъпките, които е извървяла 
            //                докато се прибира.След което, ако не е успяла да постигне целта си, на конзолата трябва да се изпише: 
            //            "{разликата между стъпките} more steps to reach goal."



            int target = 10000;
            int steps = 0;
            int totalSteps = 0;
            double diff = 0;
            string command = "";

            while (totalSteps < target)
            {
                 command = Console.ReadLine();
                
                if (command == "Going home")
                {

                    steps = int.Parse(Console.ReadLine());
                  
                    totalSteps += steps;

                    if (totalSteps < target)
                    {
                        diff = target - totalSteps;

                        Console.WriteLine($"{diff} more steps to reach goal.");

                        break;
                    }
                    else
                    {
                       Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                }
                steps = int.Parse(command);
                totalSteps += steps;
            }
           

            if (totalSteps >= target && command != "Going home")
            {
                Console.WriteLine("Goal reached! Good job!");
            }

        }
    }
}
