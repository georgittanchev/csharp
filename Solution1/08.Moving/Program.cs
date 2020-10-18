using System;
namespace _08.Moving
{
    class Moving
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double freeSpace = width * lenght * height;
            double totalSpace = 0;

            string command = Console.ReadLine();
          

            while (command != "Done")
            {

                double boxes = double.Parse(command);
                totalSpace += boxes;
                if (totalSpace > freeSpace)
                {
                  double  difference = Math.Abs(freeSpace - totalSpace);
                    Console.WriteLine($"No more free space! You need {difference} Cubic meters more.");
                    break;
                }

                command = Console.ReadLine();

            }
            if (command == "Done")
            {

                double diffenrece2 = Math.Abs(totalSpace - freeSpace);
                Console.WriteLine($"{diffenrece2} Cubic meters left.");
            }
        }
    }
}