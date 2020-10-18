using System;

namespace _03.Train
{
    class Program
    {
        static void Main(string[] args)
        {

            int train = int.Parse(Console.ReadLine());

            int people = 0;
            int sumPeople = 0;
            int[] wagon = new int[train];
            int i = 0;

            for (i = 0; i < train; i++)
            {
                people = int.Parse(Console.ReadLine());
                sumPeople += people;
                wagon[i] = people;
            }
            for (int k = 0; k < wagon.Length; k++)
            {
                Console.Write($"{wagon[k]} ");
               
            }

            Console.WriteLine($"\n{sumPeople}");

        }
    }
}
