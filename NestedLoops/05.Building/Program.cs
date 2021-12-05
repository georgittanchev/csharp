using System;

namespace _05.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int apartments = int.Parse(Console.ReadLine());
            int lastFloor = 0;
         

            for (int i = floors; i >= 1; i--)
            {
                if (i == floors)
                {
                    lastFloor = floors;
                }

              

                for (int j = 0; j < apartments; j++)
                {

                    if (i % 2 == 0 && i != lastFloor)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else if (i % 2 == 0 && i == lastFloor)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 != 0 && i == lastFloor)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 != 0 && i != lastFloor)
                    {
                        Console.Write($"A{i}{j} ");
                    }
                   
                }
                Console.WriteLine();
            }

           

        }
    }
}
